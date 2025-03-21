using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;



public class scr_menu_pausa : MonoBehaviour
{

	public GameObject p_pausa;

	public GameObject ajustes;

	public bool enpausa = false;

	public int delay = 1;

	public static scr_reinicio Instance;

	public Slider volm, volfx;

	public AudioMixer mixer;

	public Toggle check;

    public GameObject fade;

    public float tiempo;
	


	public void ActivaFull(bool pCompleta)
    {
    	Screen.fullScreen = pCompleta;
    }

	public void Continuar()
	{
		p_pausa.SetActive(false);
        Time.timeScale = 1;
        delay = 1;
        scr_reinicio.Instance.pausa = false;
	}

	public void Salir()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene("menu_ini");
		scr_reinicio.Instance.quitar = true;
	}

	public void Ajustes()
	{
		ajustes.SetActive(true);
		volm.value = scr_reinicio.Instance.vol2;
		volfx.value = scr_reinicio.Instance.volfx2;
	}

	public void QuitarAjustes()
	{
		ajustes.SetActive(false);	
	}


	public void CambiarMaster(float v)
    {
    	scr_reinicio.Instance.vol = v;
    	scr_reinicio.Instance.vol2 = v;

    	mixer.SetFloat("VolM", scr_reinicio.Instance.vol);
    }

    public void CambiarFX(float v)
    {
    	scr_reinicio.Instance.volfx = v;
    	scr_reinicio.Instance.volfx2 = v;

    	mixer.SetFloat("VolFX", scr_reinicio.Instance.volfx);
    }

    void Awake()
    {

    	volm.onValueChanged.AddListener(CambiarMaster);

    	volfx.onValueChanged.AddListener(CambiarFX);

        scr_reinicio.Instance.pausa = false;
    }


    public void Pausar()
    {
    	enpausa = true;
        scr_reinicio.Instance.pausa = true;
        p_pausa.SetActive(true);
        Time.timeScale = 0;
    }


    void Update()
    {

        tiempo += Time.deltaTime;

        

        if(tiempo > 0.7f)
        {
            fade.SetActive(false);
            tiempo = 0f;
        }

        if(Input.GetKeyDown(KeyCode.Escape) && delay == 1)
        {
        	enpausa = true;
        	scr_reinicio.Instance.pausa = true;
        	p_pausa.SetActive(true);
        	Time.timeScale = 0;
        }

        if(enpausa)
        {
        	delay += 1;
        }


        if(delay > 9)
        {
        	enpausa = false;
        	
        	if(Input.GetKeyDown(KeyCode.Escape))
        	{
        		
        		p_pausa.SetActive(false);
        		ajustes.SetActive(false);
        		Time.timeScale = 1;
        		delay = 1;
        		scr_reinicio.Instance.pausa = false;
        	}
        }
    }

    public void Pref()
    {
    	PlayerPrefs.SetFloat("volum", volm.value);
    }

    public void Preffx()
    {
    	PlayerPrefs.SetFloat("volufx", volfx.value);
    }
}

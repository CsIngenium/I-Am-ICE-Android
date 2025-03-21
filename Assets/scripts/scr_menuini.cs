using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;



public class scr_menuini : MonoBehaviour
{

	public GameObject mng;

	public GameObject fade;

	private AudioSource audioS;

	public AudioMixer mixer;

	public AudioMixer mixerfx;

	public static scr_reinicio Instance;

	public static scr_snd Instance2;

	public float i;

	public bool jugar;

	public GameObject ajustes, creditos;

	public Slider volm, volfx;


	void Start()
    {
        audioS = GetComponent<AudioSource>();
        audioS.Play();
        scr_reinicio.Instance.vol = -80f;
        Cursor.visible = true;

        if(PlayerPrefs.GetFloat("volum", volm.value) == 0f)
        {
        	PlayerPrefs.SetFloat("volum", volm.value);
        	PlayerPrefs.SetFloat("volufx", volfx.value);
        }
    }

    public void ActivaFull(bool pCompleta)
    {
    	Screen.fullScreen = pCompleta;
    }


    void Update()
    {

    	if(scr_reinicio.Instance.vol != scr_reinicio.Instance.vol2 && scr_reinicio.Instance.vol < scr_reinicio.Instance.vol2)
    	{
    		scr_reinicio.Instance.vol += 5f;
    	}

    	if(scr_reinicio.Instance.vol2 == 0f && scr_reinicio.Instance.quitar == false)
    	{
    		scr_reinicio.Instance.vol2 = PlayerPrefs.GetFloat("volum", volm.value);
    	}

    	if(scr_reinicio.Instance.volfx2 == 0f && scr_reinicio.Instance.quitar == false)
    	{
    		scr_reinicio.Instance.volfx2 = PlayerPrefs.GetFloat("volufx", volfx.value);
    	}


    	if(scr_reinicio.Instance.vol != scr_reinicio.Instance.vol2 && scr_reinicio.Instance.vol > scr_reinicio.Instance.vol2)
    	{
    		scr_reinicio.Instance.vol = scr_reinicio.Instance.vol2;
    	}

    	if(scr_reinicio.Instance.volfx != scr_reinicio.Instance.volfx2)
    	{
    		scr_reinicio.Instance.volfx = scr_reinicio.Instance.volfx2;
    	}

    	if(jugar && scr_reinicio.Instance.vol != -80f)
    	{
    		scr_reinicio.Instance.vol -= i;
    	}

    	if(volm.value != scr_reinicio.Instance.vol2)
    	{
    		volm.value = scr_reinicio.Instance.vol2;
    	}

    	if(volfx.value != scr_reinicio.Instance.volfx2)
    	{
    		volfx.value = scr_reinicio.Instance.volfx2;
    	}


    	mixer.SetFloat("VolM", scr_reinicio.Instance.vol);

    	if(jugar && scr_reinicio.Instance.quitar)
    	{
    		scr_reinicio.Instance.play = true;
    		scr_reinicio.Instance.quitar = false;
    	}

    	if(scr_reinicio.Instance.quitar)
    	{
    		volm.value = scr_reinicio.Instance.vol2;
    		volfx.value = scr_reinicio.Instance.volfx2;
    	}
    }

    public void Jugar()
    {
    	ajustes.SetActive(false);
    	creditos.SetActive(false);
    	jugar = true;
    	mng.SetActive(true);
    	fade.SetActive(true);
    }

    public void Salir()
    {
    	Application.Quit();
    }

    public void Ajustes()
    {
    	ajustes.SetActive(true);
    	creditos.SetActive(false);

    }

    public void Creditos()
    {
    	creditos.SetActive(true);
    	ajustes.SetActive(false);
    }

    public void SalirAjustes()
    {
    	ajustes.SetActive(false);
    }

    public void SalirCreditos()
    {
    	creditos.SetActive(false);
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

    	mixerfx.SetFloat("VolFX", scr_reinicio.Instance.volfx);
    }

    private void Awake()
    {
    	volm.onValueChanged.AddListener(CambiarMaster);

    	volfx.onValueChanged.AddListener(CambiarFX);
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

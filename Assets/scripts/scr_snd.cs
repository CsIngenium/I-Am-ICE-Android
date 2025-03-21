using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;



public class scr_snd : MonoBehaviour
{

	public scr_reinicio Instance;

	public static scr_snd Instance2;

	public float tiempo2, tiempo3;

	private AudioSource audioS;

	public AudioMixer mixer;

    public AudioMixer mixerfx;

	private bool reproducir = true;

	public bool final;



    void Start()
    {
        audioS = GetComponent<AudioSource>();
        scr_reinicio.Instance.vol = -80f;
        mixer.SetFloat("Voldano", -80f);
    }

    void Update()
    {

    	if(final)
    	{
    		Destroy(gameObject);
    	}

		if(reproducir == true && tiempo2 < 0.2f)
		{
			tiempo2 += Time.deltaTime;
		}

		if(reproducir == true && tiempo2 > 0.2f)
		{
			audioS.Play();
        	reproducir = false;
        	tiempo2 = 0f;
		}


    	if(scr_reinicio.Instance.pausa)
    	{
    		audioS.Pause();
            mixer.SetFloat("Voldano", -80f);
            Cursor.visible = true;
    	}

    	
    	if(scr_reinicio.Instance.pausa == false && scr_reinicio.Instance.quitar == false)
    	{
    		audioS.UnPause();
            Cursor.visible = false;
    	}


    	if(scr_reinicio.Instance.vol != scr_reinicio.Instance.vol2 && scr_reinicio.Instance.vol < scr_reinicio.Instance.vol2)
    	{
    		scr_reinicio.Instance.vol += 5f;
    	}

    	if(scr_reinicio.Instance.vol != scr_reinicio.Instance.vol2 && scr_reinicio.Instance.vol > scr_reinicio.Instance.vol2)
    	{
    		scr_reinicio.Instance.vol = scr_reinicio.Instance.vol2;
    	}

    	if(scr_reinicio.Instance.volfx != scr_reinicio.Instance.volfx2)
    	{
    		scr_reinicio.Instance.volfx = scr_reinicio.Instance.volfx2;
    	}


    	mixer.SetFloat("VolM", scr_reinicio.Instance.vol);
        
        mixerfx.SetFloat("VolFX", scr_reinicio.Instance.volfx);
    }

    private void Awake()
    {
    	if(scr_snd.Instance2 == null)
    	{
    		scr_snd.Instance2 = this;
    		DontDestroyOnLoad(this.gameObject);
    	}
    	else
    	{
    		Destroy(gameObject);
    	}
    }
}

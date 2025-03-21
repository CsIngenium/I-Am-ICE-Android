using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_charco : MonoBehaviour
{

	public scr_timer time;

	public pymv jugador;

    public scr_sndcolision colision;

    private AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
    	if(other.CompareTag("Player"))
    	{
    		time.cambio = true;
    		jugador.cambio = true;
            jugador.encharco = true;
            colision.comprobar = false;
            audioSource.Play();
    	}
    }

    void OnTriggerExit2D(Collider2D other)
    {
    	if(other.CompareTag("Player"))
    	{
    		time.cambio = false;
    		jugador.cambio = false;
            colision.comprobar = true;
    	}
    }
}

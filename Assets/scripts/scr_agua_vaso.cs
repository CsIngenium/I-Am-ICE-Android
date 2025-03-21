using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class scr_agua_vaso : MonoBehaviour
{

	public pymv jugador;

	private AudioSource audioSource;


	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

    void OnTriggerEnter2D(Collider2D other)
    {
    	if(other.CompareTag("Player"))
    		jugador.flotando = true;
    		audioSource.Play();
    }
}

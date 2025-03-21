using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_taza : MonoBehaviour
{

	public scr_timer time;

	public pymv jugador;

    public ParticleSystem p_cafe;

    public AudioSource source;

    public AudioClip externo;

    public AudioClip interno;


    void OnTriggerEnter2D(Collider2D other)
    {
    	if(other.CompareTag("Player"))
    	{
    		time.insta = true;
    		jugador.insta = true;
            p_cafe.Play();
            source.PlayOneShot(interno);
    	}
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
    	if(coll.gameObject.tag == "Player")
    	{
    		source.PlayOneShot(externo);
    	}
    }
}

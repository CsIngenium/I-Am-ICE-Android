using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_vino : MonoBehaviour
{
    public AudioSource source;

    public AudioClip externo;

    public AudioClip tapon;

    private bool mute;

    public bool sonar = true;

    public pymv Pymv;

    private float altura;



    void OnTriggerEnter2D(Collider2D other)
    {
    	if(other.CompareTag("Player"))
    	{
    		mute = true;
    	}
    }


    void OnTriggerExit2D(Collider2D other)
    {
    	if(other.CompareTag("Player"))
    	{
    		mute = false;
    	}
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
    	if(coll.gameObject.tag == "Player" && mute == false)
    	{
    		source.PlayOneShot(externo);
    	}

    	if(coll.gameObject.tag == "Player" && mute && sonar)
    	{
    		source.PlayOneShot(tapon);
            sonar = false;
            altura = Pymv.transform.position.y;
    	}
    }


    void Update()
    {
        if(Pymv.transform.position.y > (altura + 0.1f))
        {
            sonar = true;
        }
    }
}

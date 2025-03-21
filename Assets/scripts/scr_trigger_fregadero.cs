using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_trigger_fregadero : MonoBehaviour
{
    public GameObject tapon;

    private AudioSource audioSource;


    void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

    void OnTriggerEnter2D(Collider2D other)
    {
    	if(other.CompareTag("Player"))
    	{
    		tapon.SetActive(true);
    		audioSource.Play();
    	}
    }
}

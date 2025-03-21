using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_fregadero : MonoBehaviour
{

	private Animator animador;

	void Start()
	{
		animador = GetComponent<Animator>();
	}

    void OnTriggerEnter2D(Collider2D other)
    {
    	if(other.CompareTag("Player"))
    	{
    		animador.SetFloat("fadein",1);
    	}
    }
}

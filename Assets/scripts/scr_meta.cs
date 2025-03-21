using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_meta : MonoBehaviour
{
    public pymv jugador;

    void OnTriggerEnter2D(Collider2D other)
    {
    	if(other.CompareTag("Player"))
    	{
    		jugador.ganar = true;
    	}
    }
}

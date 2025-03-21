using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_calor : MonoBehaviour
{

	public scr_timer time;

	public pymv jugador;

    void OnTriggerEnter2D(Collider2D other)
    {
    	if(other.CompareTag("Player"))
    	{
    		time.cambio = true;
    		jugador.cambio = true;
    	}
    }

    void OnTriggerExit2D(Collider2D other)
    {
    	if(other.CompareTag("Player"))
    	{
    		time.cambio = false;
    		jugador.cambio = false;
    	}
    }
}

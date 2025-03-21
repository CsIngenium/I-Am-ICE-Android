using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_agua_fregadero : MonoBehaviour
{
    public pymv jugador;

    void OnTriggerEnter2D(Collider2D other)
    {
    	if(other.CompareTag("Player"))
    		jugador.flotando2 = true;
    }
}

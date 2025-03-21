using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_reinicio : MonoBehaviour
{
	public static scr_reinicio Instance;

    public float vol, vol2;

    public float volfx, volfx2;

    public bool pausa;

    public bool quitar;

    public bool play;


    private void Awake()
    {
    	if(scr_reinicio.Instance == null)
    	{
    		scr_reinicio.Instance = this;
    		DontDestroyOnLoad(this.gameObject);
    	}
    	else
    	{
    		Destroy(gameObject);
    	}
    }
}

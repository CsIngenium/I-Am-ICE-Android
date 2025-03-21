using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_timer : MonoBehaviour
{

    public float tiempo;
	public float time;

	public bool cambio = false;
    public bool insta = false;

    void Start()
    {
        time = tiempo;
    }

    void Update()
    {
        if(insta == true)
        {
            time = 0;
        }

        if(time >= 0 && cambio == false)
        {
        	time -= Time.deltaTime;
        }

        if(time >= 0 && cambio == true)
        {
        	time -= Time.deltaTime * 8;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_enemigo : MonoBehaviour
{
    
    public float fuerza;

    public Rigidbody2D RB;

    float time;

    public bool rotado;

    public bool salta;

    private SpriteRenderer sprRender;

    int aleatorio = 0;


    void Start()
    {
        sprRender = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if(time < 2f)
        {
        	time += Time.deltaTime;
        }
        else
        {
        	time = 0;
        	aleatorio = Random.Range(0,2);
        	//print(aleatorio);
        	salta = true;
        }

        
        if(aleatorio == 0 && salta == true)
        {
        	salta = false;
        	sprRender.flipX = false;
    		rotado = false;
    		RB.linearVelocity = new Vector2(-fuerza, fuerza * 2);
        }
        

        if(aleatorio == 1 && salta == true)
        {
        	salta = false;
        	sprRender.flipX = true;
    		rotado = true;
    		RB.linearVelocity = new Vector2(fuerza, fuerza * 2);
        }
    }
}

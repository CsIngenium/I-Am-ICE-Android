using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_particula : MonoBehaviour
{

	public bool rotado;

	public pymv jugador;

	public GameObject tj;

	private bool persigue;

	private bool sube = true;

	private float tiempo;

	private float tiempo_out, tiempo_out2;

	private float tiempo2, tiempo3;

	private bool moverse, moverse2;

	private bool regresar, regresar2;

	public float vel;

	int aleatorio = 0;

	public float i;

	public float j;


	void OnTriggerStay2D(Collider2D other)
    {
    	if(other.CompareTag("Player"))
    	{
    		persigue = true;

    		if(jugador.transform.position.x > transform.position.x && regresar2 == false)
    		{
    			rotado = true;
    			tiempo_out2 += Time.deltaTime;

    			if(tiempo_out2 > 0.9f)
    			{
    				moverse2 = true;
    				tiempo_out2 = 0f;
    			}

    			if(moverse2 == true)
                {
                	tiempo3 += Time.deltaTime;
                	transform.position = Vector2.MoveTowards(transform.position, tj.transform.position, j * Time.deltaTime);
                }

                if(tiempo3 > 0.83f)
                {
                	moverse2 = false;
                	regresar2 = true;
                }
    		}
    		
    		if(jugador.transform.position.x < transform.position.x && regresar2 == false)
    		{
    			rotado = false;
    			tiempo_out2 += Time.deltaTime;

    			if(tiempo_out2 > 0.9f)
    			{
    				moverse2 = true;
    				tiempo_out2 = 0f;
    			}

    			if(moverse2 == true)
                {
                	tiempo3 += Time.deltaTime;
                	transform.position = Vector2.MoveTowards(transform.position, tj.transform.position, j * Time.deltaTime);
                }

                if(tiempo3 > 0.83f)
                {
                	moverse2 = false;
                	regresar2 = true;
                }
    		}

    		if(regresar2 == true && rotado == false)
            {
                tiempo3 += Time.deltaTime;
                transform.Translate(Vector3.down * vel * -4 * Time.deltaTime);
                transform.Translate(Vector3.left * vel * 2 * Time.deltaTime);
            }

            if(tiempo3 > i)
            {
                regresar2 = false;
                tiempo3 = 0f;
            }

            if(regresar2 == true && rotado == true)
            {
                tiempo3 += Time.deltaTime;
                transform.Translate(Vector3.down * vel * -4 * Time.deltaTime);
                transform.Translate(Vector3.right * vel * 2 * Time.deltaTime);
            }

            if(tiempo3 > i)
            {
                regresar2 = false;
                tiempo3 = 0f;
            }
    	}
    }


    void OnTriggerExit2D(Collider2D other)
    {
    	if(other.CompareTag("Player"))
    		persigue = false;
    }


    void FixedUpdate()
    {

    	//print(persigue);
    	
        if(persigue == false && sube == true)
        {
        	transform.Translate(Vector3.up * vel * Time.deltaTime);
        	tiempo += Time.deltaTime;
        }

        if(tiempo > 0.4f && tiempo < 0.9f)
        {
        	sube = false;
        	transform.Translate(Vector3.down * vel * Time.deltaTime);
        	tiempo += Time.deltaTime;
        }

        if(tiempo > 0.9f)
        {
        	sube = true;
        	tiempo = 0f;
        }


        if(persigue == false && moverse == false && regresar == false)
        {
        	tiempo_out += Time.deltaTime;
        }

        if(tiempo_out > 3.5f)
        {
        	moverse = true;
        	tiempo_out = 0;
        	sube = false;

        	aleatorio = Random.Range(0,2);
        	//print(aleatorio);
        }

        if(aleatorio == 0)
        {
        	rotado = false;

        	if(moverse == true && persigue == false)
                {
                	tiempo2 += Time.deltaTime;
                	transform.Translate(Vector3.down * vel * 4 * Time.deltaTime);
                	transform.Translate(Vector3.left * vel * 2 * Time.deltaTime);
                }
        
                if(tiempo2 > 0.4f)
                {
                	moverse = false;
                	regresar = true;
                }
        
                if(regresar == true)
                {
                	tiempo2 += Time.deltaTime;
                	transform.Translate(Vector3.down * vel * -4 * Time.deltaTime);
                	transform.Translate(Vector3.left * vel * 2 * Time.deltaTime);
                }
        
                if(tiempo2 > 0.92)
                {
                	regresar = false;
                	tiempo2 = 0;
                	sube = true;
                }
        }

        if(aleatorio == 1)
        {
        	rotado = true;

        	if(moverse == true)
                {
                	tiempo2 += Time.deltaTime;
                	transform.Translate(Vector3.down * vel * 4 * Time.deltaTime);
                	transform.Translate(Vector3.right * vel * 2 * Time.deltaTime);
                }
        
                if(tiempo2 > 0.4f)
                {
                	moverse = false;
                	regresar = true;
                }
        
                if(regresar == true)
                {
                	tiempo2 += Time.deltaTime;
                	transform.Translate(Vector3.down * vel * -4 * Time.deltaTime);
                	transform.Translate(Vector3.right * vel * 2 * Time.deltaTime);
                }
        
                if(tiempo2 > 0.92)
                {
                	regresar = false;
                	tiempo2 = 0;
                	sube = true;
                }
        }
    }
}

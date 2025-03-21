using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class pymv : MonoBehaviour
{

    //asociar el rigidbody
    public Rigidbody2D RB;

    //detectar el suelo
    private bool isgrounded;
    public Transform groundcheck;
    public LayerMask cualpiso;

    //coyote
    public float coyoteTime = 0.2f;
    private float coyoteTimeCounter;

    //movimiento
    public bool izq, der, sal;

    //animaciones
    private SpriteRenderer sprRender;

    //ojos
    public bool rotado;
    public bool estatico;

    //timer
    public scr_timer timer;
    private float divisor;

    //barra de vida
    public Image barradevida;
    float vidaActual;
    float vidaMax;

    //morir
    public GameObject gcheck;
    public bool flotando, flotando2;
    private float profundidadantes;
	private float cantdesp;
	private float contador;
	private float contador2;
	private float multiplicador;
	public bool cambio = false;
    public bool insta = false;
    public GameObject daño;
    public AudioMixer mixer;
    public static scr_reinicio Instance;

    //ganar
    public bool ganar;
    public float t_ganar;

    //particulas
    public ParticleSystem p_andar_izq, p_andar_der;
    public ParticleSystem p_splash;
    public bool encharco;
    private float ptime;

    public float i;
    public float j;



    void Start()
    {
        sprRender = GetComponent<SpriteRenderer>();
    }


    public void MovIzq()
    {
    	izq = true;
    }

    public void RelIzq()
    {
    	izq = false;
    }

    public void MovDer()
    {
    	der = true;
    }

    public void RelDer()
    {
    	der = false;
    }

    public void MovSal()
    {
    	sal = true;
    }

    public void RelSal()
    {
    	sal = false;
    }

    void Update() {

        if(ganar == false)
        {
            if(Input.GetKey("a") || izq)
                {
                    RB.AddForce(new Vector2(-800f * Time.deltaTime, 0));
                }
        
                if(Input.GetKey("d") || der)
                {
                    RB.AddForce(new Vector2(800f * Time.deltaTime, 0));
                }


                if(Input.GetKey("a") || izq)
                {
                    estatico = false;
                }
                else if(Input.GetKey("d") || der)
                {
                    estatico = false;
                }
                else if(Input.GetKey("w") || sal)
                {
                    estatico = false;
                }
                else
                {
                    estatico = true;
                }
                
                //detectar el piso
                isgrounded = Physics2D.OverlapCircle(groundcheck.position,.2f,cualpiso);
                

                if (isgrounded)
                {
                    coyoteTimeCounter = coyoteTime;
                }
                else
                {
                    coyoteTimeCounter -= Time.deltaTime;
                }

                Debug.Log(coyoteTimeCounter);


                if(Input.GetKey("w") || sal)
                	if((isgrounded || coyoteTimeCounter > 0) && flotando == false && flotando2 == false)
                    {
                        RB.linearVelocity = new Vector2(RB.linearVelocity.x, 19f);
                        coyoteTimeCounter = 0;
                    }


                if(RB.linearVelocity.x < 0)
                {
                    sprRender.flipX = true;
                    rotado = true;
                }
                else
                {
                    sprRender.flipX = false;
                    rotado = false;
                }
        }//
    }

    void FixedUpdate()
    {
    	//-------------------------------------------------------------

        if(isgrounded == true && rotado == false && estatico == false)
        {
            p_andar_izq.Play();
        }
        
        if(isgrounded == true && rotado == true && estatico == false)
        {
            p_andar_der.Play();
        }

        if(encharco)
        {
            ptime += Time.deltaTime;
        }

        if(ptime > 0.1f && ptime < 0.2f && encharco)
        {
            p_splash.Play();
        }

        if(ptime > 0.2f)
        {
            ptime = 0;
            encharco = false;
        }

        if(ganar == false)
    	{
            vidaMax = timer.tiempo;
        
            vidaActual = timer.time;
        
            barradevida.fillAmount = vidaActual / vidaMax;
        
            float cons = 0.00075f;
        
            float divi = timer.tiempo / 10f;
        
            divisor = cons / divi;
        
            if(insta == true)
            {
                transform.localScale = new Vector3(0, 0 ,0);
            }
        
            if(transform.localScale.y >= 0.12 && cambio == false)
            {
                transform.localScale -= new Vector3(0, divisor ,0);
                daño.SetActive(false);
                mixer.SetFloat("Voldano", -80f);
            }
        
            if(transform.localScale.y >= 0.12 && cambio == true)
            {
                 transform.localScale -= new Vector3(0, divisor * 8,0);
                 daño.SetActive(true);
                 mixer.SetFloat("Voldano", scr_reinicio.Instance.vol);
            }
        }

		if(transform.position.y <= -6f)
			contador2 += Time.deltaTime;

		if(contador2 >= 3f)
        	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		

        if(flotando == true)
        {
            gcheck.SetActive(false);
        	cantdesp = 5;
        	profundidadantes = 2.7f;
        	multiplicador = Mathf.Clamp01(-transform.position.y / profundidadantes) * cantdesp;

			RB.AddForce(new Vector3(0f,Mathf.Abs(Physics.gravity.y) * multiplicador,0f), ForceMode2D.Force);

			contador += Time.deltaTime;
        }

        if(flotando2 == true)
        {
            gcheck.SetActive(false);
            cantdesp = i;
            profundidadantes = j;
            multiplicador = Mathf.Clamp01(-transform.position.y / profundidadantes) * cantdesp;

            RB.AddForce(new Vector3(0f,Mathf.Abs(Physics.gravity.y) * multiplicador,0f), ForceMode2D.Force);

            contador += Time.deltaTime;
        }

        if(contador > 0.1f && contador < 0.2f)
        {
            p_splash.Play();
        }


        if(contador >= 3f)
          SceneManager.LoadScene(SceneManager.GetActiveScene().name);


        if(transform.localScale.y < 0.12)
        {
            transform.localScale = new Vector3(0, 0 ,0);
        }

        if(ganar)
        {
            t_ganar += Time.deltaTime;
        }

        if(t_ganar > 2.9f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

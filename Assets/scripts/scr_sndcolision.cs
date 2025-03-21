using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_sndcolision : MonoBehaviour
{

	private AudioSource audioSource;

	public bool sonar = true;

	public pymv Pymv;

	private float altura;

	public bool comprobar = true;


	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
    	if(coll.gameObject.tag == "Player" && sonar && comprobar)
    	{
    		audioSource.Play();
    		sonar = false;
    		altura = Pymv.transform.position.y;
    	}
    }

    void Update()
    {
    	if(Pymv.transform.position.y > (altura + 0.1f))
    	{
    		sonar = true;
    	}
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_ojos_enp : MonoBehaviour
{
    [SerializeField]
    Transform target;

    public scr_particula enemigo;

    public Transform objetivo;


    private void Start()
    {
    	if(target == null)
    		target = transform;
    }

    void Update()
    {
        if(enemigo.rotado == true)
        {
            transform.position = new Vector3(objetivo.position.x + 0.03f, objetivo.position.y - 0.05f, objetivo.position.z);
        }
        else
        {
            transform.position = new Vector3(objetivo.position.x - 0.03f, objetivo.position.y - 0.05f, objetivo.position.z);
        }
    }
}

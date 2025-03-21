using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ctrlcamara : MonoBehaviour
{

	public Transform target;
	public pymv jugador;

    // Update is called once per frame
    void Update()
    {
        if(jugador.transform.position.y > -7f)
        {
        	transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
        }
    }
}

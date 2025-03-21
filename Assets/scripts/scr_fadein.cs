using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_fadein : MonoBehaviour
{

	private float tiempo;

	public GameObject fade;

    void Update()
    {
        tiempo += Time.deltaTime;

        if(tiempo > 1f)
        {
        	fade.SetActive(false);
        }
    }
}

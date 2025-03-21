using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class scr_p5 : MonoBehaviour
{
    public bool activo;

	void Start()
	{
		transform.localScale = new Vector3(0, 0 ,0);
	}

    void Update()
    {
        if(activo == true && transform.localScale.x < 2.2f)
        {
        	transform.Rotate(0f,0f,1.6f);
        	transform.localScale += new Vector3(0.04f, 0.04f,0);
        }

        if(transform.localScale.x >= 2.2f)
        {
        	activo = false;
        	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr_logo_trans : MonoBehaviour
{
    private float tiempo;

    void Update()
    {
    	tiempo += Time.deltaTime;

    	if(tiempo > 4f)
    	{
    		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    	}
    }
}

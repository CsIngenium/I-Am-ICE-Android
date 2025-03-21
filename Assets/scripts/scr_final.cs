using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class scr_final : MonoBehaviour
{
    
	private float tiempo;

	public static scr_reinicio Instance;

	public static scr_snd Instance2;

	void Start()
	{
		scr_snd.Instance2.final = true;
	}

    void Update()
    {

        tiempo += Time.deltaTime;

        if(tiempo > 2.9f)
        {
        	SceneManager.LoadScene("menu_ini");
        }
    }
}

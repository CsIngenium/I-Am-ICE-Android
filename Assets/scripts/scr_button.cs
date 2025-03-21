using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_button : MonoBehaviour
{
    
    public AudioSource audioS;

    public AudioClip hoverfx;

    public AudioClip clickfx;


    public void HoverS()
    {
    	audioS.PlayOneShot(hoverfx);
    }


    public void ClickS()
    {
    	audioS.PlayOneShot(clickfx);
    }

}

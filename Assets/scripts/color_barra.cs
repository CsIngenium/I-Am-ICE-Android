using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class color_barra : MonoBehaviour
{

	Graphic grafico;

    public Image barradevida;

    Color transicion;

    void Start()
    {
    	grafico = GetComponent<Graphic>();
    	transicion = new Color32(0,75,255,255);
    	grafico.color = transicion;
    }

    void Update()
    {
    	float vida = barradevida.fillAmount * 100;
    	int porcentaje = (int)vida;
    	//print(porcentaje);

    	if(porcentaje > 10 && porcentaje < 40)
    	{
    		transicion = Color.Lerp(transicion,Color.yellow,0.1f);
    	}

    	if(porcentaje < 10)
    	{
    		transicion = Color.Lerp(transicion,Color.red,0.1f);
    	}

    	grafico.color = transicion;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_manager_transout : MonoBehaviour
{

	public scr_p1 p1_1;
	public scr_p1 p1_2;
	public scr_p1 p1_3;
	public scr_p1 p1_4;
	public scr_p1 p1_5;
	public scr_p1 p1_6;
	public scr_p1 p1_7;
	public scr_p1 p1_8;

	public bool act_p2;

	public scr_p2 p2_1;
	public scr_p2 p2_2;
	public scr_p2 p2_3;
	public scr_p2 p2_4;
	public scr_p2 p2_5;
	public scr_p2 p2_6;
	public scr_p2 p2_7;
	public scr_p2 p2_8;

	public bool act_p3;

	public scr_p3 p3_1;
	public scr_p3 p3_2;
	public scr_p3 p3_3;
	public scr_p3 p3_4;
	public scr_p3 p3_5;
	public scr_p3 p3_6;
	public scr_p3 p3_7;
	public scr_p3 p3_8;

	public bool act_p4;

	public scr_p4 p4_1;
	public scr_p4 p4_2;
	public scr_p4 p4_3;
	public scr_p4 p4_4;
	public scr_p4 p4_5;
	public scr_p4 p4_6;
	public scr_p4 p4_7;
	public scr_p4 p4_8;

	public bool act_p5;

	public scr_p5 p5_1;
	public scr_p5 p5_2;
	public scr_p5 p5_3;
	public scr_p5 p5_4;
	public scr_p5 p5_5;
	public scr_p5 p5_6;
	public scr_p5 p5_7;
	public scr_p5 p5_8;

    void Update()
    {

    	p1_1.activo = true;
        p1_2.activo = true;
        p1_3.activo = true;
        p1_4.activo = true;
        p1_5.activo = true;
        p1_6.activo = true;
        p1_7.activo = true;
        p1_8.activo = true;

        if(act_p2 == true)
        {
        	p2_1.activo = true;
        	p2_2.activo = true;
        	p2_3.activo = true;
        	p2_4.activo = true;
        	p2_5.activo = true;
        	p2_6.activo = true;
        	p2_7.activo = true;
        	p2_8.activo = true;
        }

        if(act_p3 == true)
        {
        	p3_1.activo = true;
        	p3_2.activo = true;
        	p3_3.activo = true;
        	p3_4.activo = true;
        	p3_5.activo = true;
        	p3_6.activo = true;
        	p3_7.activo = true;
        	p3_8.activo = true;
        }

        if(act_p4 == true)
        {
        	p4_1.activo = true;
        	p4_2.activo = true;
        	p4_3.activo = true;
        	p4_4.activo = true;
        	p4_5.activo = true;
        	p4_6.activo = true;
        	p4_7.activo = true;
        	p4_8.activo = true;
        }

        if(act_p5 == true)
        {
        	p5_1.activo = true;
        	p5_2.activo = true;
        	p5_3.activo = true;
        	p5_4.activo = true;
        	p5_5.activo = true;
        	p5_6.activo = true;
        	p5_7.activo = true;
        	p5_8.activo = true;
        }
    }
}

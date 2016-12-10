using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{


    public GameObject[] buttons;
	// Use this for initialization
	void Start () {
	    for (int i = 0; i < 4; i++)
	    {
	        buttons[i].GetComponent<Renderer>().enabled = false;
	    }
	}
	
	// Update is called once per frame
	void Update () {

	    if (Input.GetAxis("LeftRight") == -1)
	    {
	        buttons[0].GetComponent<Renderer>().enabled = true;
	    }else if (Input.GetAxis("LeftRight") == 1)
	    {
            buttons[1].GetComponent<Renderer>().enabled = true;
        }else if (Input.GetButton("Jump"))
	    {
            buttons[2].GetComponent<Renderer>().enabled = true;
        }else if (Input.GetButton("Shoot") || Input.GetAxis("Shoot") >= 0.5)
	    {
            buttons[3].GetComponent<Renderer>().enabled = true;
        }else if (Input.GetButton("Pause"))
	    {
	        buttons[4].GetComponent<Renderer>().enabled = true;
	    }

        //Controller2
        else if (Input.GetAxis("LeftRight2") == -1)
        {
            buttons[5].GetComponent<Renderer>().enabled = true;
        }
        else if (Input.GetAxis("LeftRight2") == 1)
        {
            buttons[6].GetComponent<Renderer>().enabled = true;
        }
        else if (Input.GetButton("Jump2"))
        {
            buttons[7].GetComponent<Renderer>().enabled = true;
        }
        else if (Input.GetButton("Shoot2"))
        {
            buttons[8].GetComponent<Renderer>().enabled = true;
        }
        else if (Input.GetButton("Pause2"))
        {
            buttons[9].GetComponent<Renderer>().enabled = true;
        }
        else
	    {
	        for (int i = 0; i < 10; i++)
	        {
	            buttons[i].GetComponent<Renderer>().enabled = false;
	        }
	    }
        
    }
}

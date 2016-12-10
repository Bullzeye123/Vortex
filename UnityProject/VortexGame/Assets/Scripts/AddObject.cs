using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddObject : MonoBehaviour {

    public GameObject powerUp;

    public Transform postionLeft;
    public Transform postionRight;
    public Transform postionBack;

    private bool posLeft;
    private bool posRight;
    private bool posBack;

    // Use this for initialization
    void Start () {
        Debug.Log(transform.position);
        posLeft = true;
        posRight = true;
        posBack = true;
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        // If Button is pressed spawn Object
        if (Input.GetKeyDown(KeyCode.A) && posLeft)
        {
            Instantiate(powerUp, postionLeft.position, postionLeft.rotation);
            posLeft = false;
        }
        else if (Input.GetKeyDown(KeyCode.D) && posRight)
        {
            Instantiate(powerUp, postionRight.position, postionRight.rotation);
            posRight = false;
        }
        else if (Input.GetKeyDown(KeyCode.S) && posBack)
        {
            Instantiate(powerUp, postionBack.position, postionBack.rotation);
            posBack = false;
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public int speed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {

        Vector3 rotate = new Vector3(0.0f, -1.0f * speed, 0.0f);
        this.transform.Rotate(rotate);
    }
}

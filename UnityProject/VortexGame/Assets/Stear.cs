using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stear : MonoBehaviour {

    public int speed;
    public int tilt;
    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(-moveHorizontal, 0.0f, 0.0f)*speed;

        rb.transform.Rotate(movement);
    }
}

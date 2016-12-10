using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltWaver : MonoBehaviour {

    public float tilt;
    public float speed;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(-moveHorizontal, 0.0f, -moveVertical);

        rb.velocity = movement * speed;

        rb.rotation = Quaternion.Euler(0.0f, rb.velocity.x * tilt, rb.velocity.x * tilt);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax;
}

public class TiltWaver : MonoBehaviour {

    public int speed;
    public int tilt;
    public float offset;
    public Boundary boundary;

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
        performSideMotion();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            performSideMotion();
        }
        
    }

    void performSideMotion()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(-moveHorizontal, 0.0f, 0.0f);
        rb.velocity = movement * speed;

        float newX = transform.localPosition.x - moveHorizontal / 10;
        float newY = -Mathf.Exp(-newX / 100) + offset;

        transform.localPosition = new Vector3
    (
        newX,
        newY,
        transform.localPosition.z
    );
        Debug.Log(rb.transform.localPosition);

        transform.localRotation = Quaternion.Euler(0.0f, rb.velocity.x * -tilt, rb.velocity.x * -tilt);
    }

}

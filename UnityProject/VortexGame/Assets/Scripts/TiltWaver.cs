using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltWaver : MonoBehaviour {

    public float tilt;
    public float speed;
    private Rigidbody rb;

    public GameObject spawn;

    private int points;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(-moveHorizontal, 0.0f, -moveVertical)*speed;

        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);

        rb.rotation = Quaternion.Euler(0.0f, rb.velocity.x * tilt, rb.velocity.x * tilt);
    }

    void OnTriggerEnter(Collider otherCollision)
    {
        GameObject other = otherCollision.gameObject;

        if (other.tag.Equals("Border") && spawn !=null)
        {
            transform.position = spawn.transform.position;
            transform.rotation = spawn.transform.rotation;
            points--;
        }

        
        if (other.tag.Equals("Round"))
        {
            points++;
            Debug.Log(points);
        }

        if (other.tag.Equals("Obstacle"))
        {
            points--;
            Destroy(other.gameObject);
        }


    }

    void OnCOllision(Collision other)
    {
        GameObject gO = other.gameObject;

        if (gO.tag.Equals("Obstacle"))
        {
            points--;
            Destroy(other.gameObject);
        }
    }

    void OnGui()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Points: "+points);
    }
}

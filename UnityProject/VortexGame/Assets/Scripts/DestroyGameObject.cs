using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{

    public float destroyAfter;
	
	// Update is called once per frame
	void Update () {
	    if (destroyAfter < 0)
	    {
	        destroy();
	    }
	    destroyAfter -= Time.deltaTime;
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "player")
        {
            destroy();
        }
    }

    void destroy()
    {
        GameObject.Destroy(gameObject);
    }
}

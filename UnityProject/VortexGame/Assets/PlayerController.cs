using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject Player;

    public GameObject Engine1;
    public GameObject Engine2;
    public GameObject LaneKick;

    public Transform positionLeft;
    public Transform positionRight;
    public Transform positionBack;

    private GameObject engine;
    private GameObject punch;

    // Use this for initialization
    void Start () {
        changePowerUps(Engine1, positionBack, ref engine);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            changePowerUps(LaneKick, positionLeft, ref punch);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(engine.name);
            switch (engine.name)
            {
                case "Engine1(Clone)":
                    changePowerUps(Engine2, positionBack, ref engine);
                    break;
                case "Engine2(Clone)":
                    changePowerUps(Engine1, positionBack, ref engine);
                    break;
            }
        }
    }

    private void changePowerUps(GameObject obj,Transform pose, ref GameObject dst)
    {
        if(dst != null)
        {
            Destroy(dst.gameObject);
        }

        dst = Instantiate(obj, pose.position, pose.rotation);
        dst.tag = pose.tag;
        dst.transform.parent = Player.transform;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Player : MonoBehaviour {
    public GameObject[] tracks;
    private GameObject CurrentTrack;

    public GameObject respawn;

    private int tracknumber;
    public string player;
    private float lastpress;
	// Use this for initialization
	void Start () {

        CurrentTrack = transform.parent.gameObject;
        for (int i =0; i<6;i++)
        {
            if (CurrentTrack.name.Equals(tracks[i].name))
            {
                tracknumber = i;
            }
            Debug.Log(tracknumber);
        }
               

	}
    private void Update()
    {

        if (Input.GetAxis("LeftRight") == -1 && lastpress <0)
        {
            lastpress = 0.5f;
            if (tracknumber > 0)
            {
                transform.SetParent(tracks[tracknumber - 1].transform);
                tracknumber = tracknumber - 1;
                // if (tracknumber == 6)
                //   transform.position = new Vector3(0, 0, 0);
                if (tracknumber == 5)
                {
                    transform.Translate(0, -2, -0.5f);
                }
                    if (tracknumber == 4)
                {
                    transform.Translate(0, -2, -0.5f);
                }
                 if (tracknumber == 3)
                {
                    transform.Translate(0, -2, -0.8f);
                }
                 if (tracknumber == 2)
                {
                    transform.Translate(0, -2, -0.4f);
                    transform.Rotate(10, 0, 0);
                }
                 if (tracknumber == 1)
                {
                    transform.Translate(0, -2, -1.3f);
                    transform.Rotate(20, 0, 0);
                }
                if (tracknumber == 0)
                {
                    transform.Translate(0, -2, -0.3f);
                    transform.Rotate(40, 0, 0);
                }
                Debug.Log(tracknumber);
            }
            else
            {                
                tracknumber = 5;                
                transform.position = respawn.transform.position+Vector3.up*2;
                transform.rotation = respawn.transform.rotation;
                transform.SetParent(tracks[5].transform);
                Debug.Log(tracknumber);
            }
        }
        if (Input.GetAxis("LeftRight" + player)== 1 && lastpress < 0)
        {
            lastpress = 0.5f;
            if (tracknumber <5)
            {
                transform.SetParent(tracks[tracknumber + 1].transform);
                tracknumber = tracknumber +1;
                if (tracknumber > 0)
                {
                    if (tracknumber == 6)
                        transform.Translate(0, 2, 0.5f);
                    if (tracknumber == 5)
                    {
                        transform.Translate(0, 2, 0.5f);
                    }
                    if (tracknumber == 4)
                    {
                        transform.Translate(0, 2, 0.8f);
                    }
                    if (tracknumber == 3)
                    {
                        transform.Translate(0, 2, 0.4f);
                        transform.Rotate(-10, 0, 0);

                    }
                    if (tracknumber == 2)
                    {
                        transform.Translate(0, 2, 1.3f);
                        transform.Rotate(-20, 0, 0);
                    }
                    if (tracknumber == 1)
                    {
                        transform.Translate(0, 2, 0.3f);
                        transform.Rotate(-40, 0, 0);

                    }                   
                    Debug.Log(tracknumber);
                }
            }
        }
        lastpress -= Time.deltaTime;
    }
}

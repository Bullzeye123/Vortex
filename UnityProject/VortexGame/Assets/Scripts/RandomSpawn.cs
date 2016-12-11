using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = System.Random;

public class RandomSpawn : MonoBehaviour
{
    private static Random r;
    public float spawntime;
    public bool laneDisabled;

    public int ran_Low;
    public int ran_High;

    private String[] tagList;

    public GameObject tree, box, car;

    private Hashtable obstacles;
    private GameObject[] objectList;

    void Start()
    {
        r=new Random();

        tagList = new string[] {"Obstacle"};

        objectList = new GameObject[] {tree,box,car};

        
    }

    void Update()
    {
        if (spawntime < 0)
        {
            int ran = randomNumber(0, 3);
            GameObject newObject = Instantiate(objectList[ran], transform.position, Quaternion.Euler(0, 0, 0));
            newObject.tag = tagList[0];
            spawntime = randomNumber(ran_Low, ran_High);
            //Debug.Log(spawntime);
        }
        else
        {
            spawntime -= Time.deltaTime;
        }
    }

    private int randomNumber(int low, int high)
    {
        
        return r.Next(low, high);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helper{

    public static Vector3 AddAxisForce(string axis)
    {
        switch (axis)
        {
            case "x":
                return new Vector3(1.0f, 0.0f, 0.0f);
            case "y":
                return new Vector3(0.0f, 1.0f, 0.0f);
            case "z":
                return new Vector3(0.0f, 0.0f, 1.0f);
        }

        return new Vector3(0.0f, 0.0f, 0.0f);
    }

    public static Vector3 k2D(GameObject obj, float x, float v, float a, string axis)
    {
        float m = obj.GetComponent<Rigidbody>().mass;
        Vector3 dir = new Vector3(0.0f, 0.0f, 0.0f); ;

        switch (axis)
        {
            case "x":
                dir = new Vector3(1.0f, 0.0f, 0.0f);
                break;
            case "y":
                dir = new Vector3(0.0f, 1.0f, 0.0f);
                break;
            case "z":
                dir = new Vector3(0.0f, 0.0f, 1.0f);
                break;
        }

        return m * (float)(0.5 * Mathf.Pow(x,2) + v * x + a) * dir;
    }
}

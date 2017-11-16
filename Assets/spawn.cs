using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {
    public Transform sphere;
    public float scaleDown = 0.8f;
    public float scaleUp = 1.25f;
    public float scale = 1f;

    public static bool success = false;
    public static bool fail = false;

    // Use this for initialization
    void Start () {
    }

// Update is called once per frame
    void Update () {

       if(fail)//&&  !(GameObject.FindWithTag("sphere")))
        {
            var sphereClone = Instantiate(sphere);
            scale = scale * scaleUp;
            sphereClone.transform.localScale = sphere.transform.localScale * scale;
            fail = false;
        }

        if (success)
         {
            var sphereClone = Instantiate (sphere);
            scale = scale * scaleDown;
            sphereClone.transform.localScale = sphere.transform.localScale * scale; //new Vector3 (sphere.transform.localScale.x * 0.9,0.2f,0.2f);
            success = false;
        }
    }
}

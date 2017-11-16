using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enter : MonoBehaviour {
   // public static bool success = false;
    private string filePath = "D:/mycoords.txt";
    private string coordinates = "";
    private static int numFrames = 90; //number of frames to capture @ 90fps
    private int count = 0;


    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Renderer>().material.color = Color.red;
        Debug.Log(gameObject.name +"was triggered by!"+other.gameObject.name);
        coordinates = "";
        count = 0;

    }
    private void OnTriggerExit(Collider other)
    {
        GetComponent<Renderer>().material.color = Color.green;
        Debug.Log(gameObject.name + "was triggered by!" + other.gameObject.name);
        coordinates = "";
        count = 0;
    }

    void OnTriggerStay(Collider other)
    {
        count++;
        Debug.Log("count:" + count);
            
        Transform trans = other.transform;
        coordinates += "x: " + trans.position.x.ToString() + ", y: " + trans.position.y.ToString() + ", z: " + trans.position.z.ToString() + ", time: " + Time.deltaTime.ToString() + System.Environment.NewLine;
        if (count == numFrames)
        {
            spawn.success = true;
            System.IO.File.WriteAllText(filePath, coordinates);
            coordinates = "";
            count = 0;
            Object.Destroy(this.gameObject);

        }
    }


    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log(gameObject.name + "was collided by!" + collision.gameObject.name);

    //}
}

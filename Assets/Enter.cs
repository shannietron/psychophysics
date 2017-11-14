using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enter : MonoBehaviour {
    private string filePath = "D:/mycoords.txt";
    private string coordinates = "";


    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Renderer>().material.color = Color.red;
        Debug.Log(gameObject.name +"was triggered by!"+other.gameObject.name);

    }
    private void OnTriggerExit(Collider other)
    {
        GetComponent<Renderer>().material.color = Color.green;
        Debug.Log(gameObject.name + "was triggered by!" + other.gameObject.name);

    }

    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody)
            coordinates = "";
            Transform trans = other.transform;
            coordinates += "x: " + trans.position.x.ToString() + ", y: " + trans.position.y.ToString() + ", z: " + trans.position.z.ToString() + System.Environment.NewLine;
            System.IO.File.WriteAllText(filePath, coordinates);


    }


    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log(gameObject.name + "was collided by!" + collision.gameObject.name);

    //}
}

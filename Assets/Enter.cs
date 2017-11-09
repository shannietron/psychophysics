using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour {

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

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log(gameObject.name + "was collided by!" + collision.gameObject.name);

    //}
}

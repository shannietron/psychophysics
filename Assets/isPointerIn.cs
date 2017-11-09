using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isPointerIn : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + "was collided by!" + other.gameObject.name);
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray raycast = new Ray(transform.position, transform.forward);

        RaycastHit hitObject;
        bool rayHit = Physics.Raycast(raycast, out hitObject, 0.1f);

        if (rayHit && hitObject.collider.GetComponent<SphereCollider>() != null)
        {
            Debug.Log("BALLOON! Wheeeeee");
           //hitObject.collider.gameObject.SendMessageUpwards("ApplyDamage", SendMessageOptions.DontRequireReceiver);
        }
    }
}

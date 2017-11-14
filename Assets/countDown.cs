using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countDown : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("Countdown", 5);

    }
	
	// Update is called once per frame
	void Update () {

		
	}

    private IEnumerator Countdown(int time)
    {
        while (time > 0)
        {
            Debug.Log(time--);
            yield return new WaitForSeconds(1);
        }
        Debug.Log("Countdown Complete!");
        Object.Destroy(this.gameObject);

    }
}

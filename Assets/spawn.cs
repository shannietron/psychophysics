using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {
    public Transform sphere;
    public float scaleDown = 0.8f;
    public float scaleUp = 1.25f;
    public float scale = 1f;
    public string pos;

    public static bool success = false;
    public static bool fail = false;
    private System.DateTime startGame;
    private string startGameString;
    private string filePath;
    

    //private string filePath = "scale.txt";

    // Use this for initialization
    void Start () {
        startGame = System.DateTime.Now;
        startGameString = startGame.ToString("dd-mm-yyyy-hh-mm-ss");
        filePath = "Data/" +pos+ "coords" + startGameString + ".txt";

}

    // Update is called once per frame
    void Update () {

       // System.IO.File.WriteAllText(filePath, scale.ToString()+ System.Environment.NewLine);
        

        if (fail)//&&  !(GameObject.FindWithTag("sphere")))
        {
            var sphereClone = Instantiate(sphere);
            scale = scale * scaleUp;
            System.IO.File.AppendAllText(filePath, scale.ToString() + System.Environment.NewLine);
            sphereClone.transform.localScale = sphere.transform.localScale * scale;
            fail = false;
        }

        if (success)
         {
            var sphereClone = Instantiate (sphere);
            scale = scale * scaleDown;
            System.IO.File.AppendAllText(filePath, scale.ToString() + System.Environment.NewLine);
            sphereClone.transform.localScale = sphere.transform.localScale * scale; //new Vector3 (sphere.transform.localScale.x * 0.9,0.2f,0.2f);
            success = false;
        }
    }
}

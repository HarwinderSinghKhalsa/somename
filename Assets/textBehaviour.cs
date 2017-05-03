using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textBehaviour : MonoBehaviour {
    public Text txt;
    int counter =0;
	// Use this for initialization
    public void IncrementCounter()
    {
        counter++;
        txt.text = "" + counter;
    }
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

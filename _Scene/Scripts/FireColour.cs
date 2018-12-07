using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireColour : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material.color = new Color(255, 0, 0); //C sharp
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

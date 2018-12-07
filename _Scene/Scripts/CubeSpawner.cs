using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {


    public GameObject CubePrefab;
    public Transform CubeSpawn;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () { }


    void OnTriggerEnter(Collider collider)
    {
        if (collider != null) {
        GameObject otherObj = collider.gameObject;
        Debug.Log("Triggered with: " + otherObj);
            GetComponent<Renderer>().material.color = new Color(0, 255, 0); //Change the colour
            spawnCube();
        }
    }

    void spawnCube()
    {
        GameObject Cube = Instantiate(
            CubePrefab,
            CubeSpawn.position,
            CubeSpawn.rotation);

        Cube.GetComponent<Rigidbody>();
    }
} 

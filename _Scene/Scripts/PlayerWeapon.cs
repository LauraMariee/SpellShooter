using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{

    public GameObject FirePrefab;
    public Transform FireSpawn;



    public void Start()
    {
        
        GetComponent<MeshRenderer>().material.color = Color.blue;

        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        FirePrefab.transform.Rotate(Vector3.up, 70f);//move wand

        // Create the Bullet from the Bullet Prefab
        GameObject Fire = Instantiate(
            FirePrefab,
            FireSpawn.position,
            FireSpawn.rotation);

        // camera and velocity variables
        float x = Screen.width / 2;
        float y = Screen.height / 2;
        var ray = Camera.main.ScreenPointToRay(new Vector3(x, y, 0));


        // Add velocity to the bullet
        Fire.GetComponent<Rigidbody>().velocity = ray.direction * 20;


        // Destroy the bullet after 3 seconds
        Destroy(Fire, 0.3f);
     
        
        FirePrefab.transform.Rotate(Vector3.down, 70f);//move wand



    }


    
}

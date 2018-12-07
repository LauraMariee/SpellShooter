using UnityEngine;

public class DestroyCubes : MonoBehaviour
{
    public int cubeHealth = 3;

    void OnTriggerEnter(Collider collider)
    {
        
        if(collider != null)
        {
            GameObject otherObj = collider.gameObject;
            Debug.Log("Triggered with: " + otherObj);
            cubeHealth--;
            if(cubeHealth <= 0)
            {
                DestroyObject(gameObject);
                //DestroyObject(otherObj);
            }
            
            //particle emitter 
        }
        
    }
}
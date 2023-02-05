using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlySpawner : MonoBehaviour
{
    // Create a public variable to hold a reference to the prefab
    public GameObject flyPrefab;
    
    // Create a fly prefab every 10 seconds
    void Start()
    {
        InvokeRepeating("SpawnFly", 0, 13);
    }
    
    // Spawn a fly at a random position
    void SpawnFly()
    {
        // Set a random position for the fly inside the collider bounds of this GameObject
        // Vector3 position = new Vector3(
        //     Random.Range(transform.position.x - 1, transform.position.x + 1),
        //     Random.Range(transform.position.y - 1, transform.position.y + 1),
        //     transform.position.z
        // );
        
        // Instantiate the fly at the random position
        Instantiate(flyPrefab, transform.position, Quaternion.identity);
    }
    
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlySpawner : MonoBehaviour
{
    public GameObject flyPrefab;
    
    void Start()
    {
    // Spawn a fly every 13 seconds
        InvokeRepeating("SpawnFly", 0, 13);
    }
    
    void SpawnFly()
    {
        // );
        
        // Instantiate the fly at the random position
        Instantiate(flyPrefab, transform.position, Quaternion.identity);
    }
    
    
}

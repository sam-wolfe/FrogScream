using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyDespawner : MonoBehaviour
{
    // Despawn any flies that enter the collider
    void OnTriggerEnter(Collider other)
    {
        // Destroy the fly if it enters the collider, only fly objects
        if (other.gameObject.CompareTag("Fly"))
        {
            Destroy(other.transform.parent.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    
    // Fly horizontal speed
    public float speed = 1.0f;
    
    // Fly vertical speed
    public float amplitude = 1.0f;
    
    void Start() {
        
    }

    void Update() {
        // Move the fly right at the horizontal speed
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        
        // Move the fly up and down at the vertical speed with a sine wave and slight randomness
        transform.Translate(Vector3.up * amplitude * Mathf.Sin(Time.time) * Random.Range(0.5f, 1.0f) * Time.deltaTime);
    }
}

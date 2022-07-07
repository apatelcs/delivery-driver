using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // OnCollisionEnter2D is called when the car first collides with another game object
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Car collided with something");
    }

    // On TriggerEnter2D is called when the car first passes through another game object with trigger turned on
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Car entered something");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door6 : MonoBehaviour
{
    // Public static variable
    public static int k6 = 0;

    // Called when a collision occurs
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if x is equal to 1
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player") && k6 == 1)
        {
            // Increment the key count

            // Destroy the key object
            Destroy(gameObject);
        }

    }
}
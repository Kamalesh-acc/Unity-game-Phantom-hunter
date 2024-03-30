using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power2 : MonoBehaviour
{
    public static int power = 1
        ;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if colliding with an object on the "Player" layer
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            // Increment the power variable based on your condition
            if (power == 1)
            {
                power = 2;
            }
            else if (power == 2)
            {
                power = 3;
            }
            else if (power == 3)
            {
                power = 4;
            }

            // Destroy the power object
            Destroy(gameObject);
        }
    }
}

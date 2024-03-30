using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerbase22 : MonoBehaviour
{
    public static bool istrigger = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            istrigger = true;
            // Perform additional actions specific to colliding with the player
        }
    }
}

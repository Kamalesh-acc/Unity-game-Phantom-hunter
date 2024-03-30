using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallout : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        
            Destroy(other.gameObject);
            // Perform additional actions specific to colliding with the player
        
    }
}

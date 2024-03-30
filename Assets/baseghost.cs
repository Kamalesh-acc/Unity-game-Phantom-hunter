using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseghost : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the enemy is hit by a bullet
        if (collision.gameObject.CompareTag("Player"))
        {
            
            Destroy(collision.gameObject); 
        }
        
    }
}

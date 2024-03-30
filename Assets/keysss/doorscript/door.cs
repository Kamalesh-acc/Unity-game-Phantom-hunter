using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public AudioSource open;
    public static int k1 = 0;

    // Called when a collision occurs
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player") && k1==1)
        {
            
            Destroy(gameObject);
        }
    }
}
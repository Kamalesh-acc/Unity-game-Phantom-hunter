using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key5 : MonoBehaviour
{
    private void Start()
    {
        if (door5.k5 == 1)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            // Increment the key count
            door5.k5 += 1;
            // Destroy the key object
            Destroy(gameObject);
        }
    }
}
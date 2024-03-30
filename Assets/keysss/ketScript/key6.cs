using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key6 : MonoBehaviour
{
    private void Start()
    {
        if (door6.k6 == 1)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            // Increment the key count
            door6.k6 += 1;
            // Destroy the key object
            Destroy(gameObject);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundMagic : MonoBehaviour
{
    public AudioSource keySound;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the colliding object has the tag "key"
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collided with key");
            // Play the assigned sound
            keySound.Play();
        }
    }
}

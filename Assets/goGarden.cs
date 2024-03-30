using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goGarden : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with a specific tag or layer if needed
        // For example, if the other object has a "Player" tag
        if (collision.gameObject.CompareTag("Player"))
        {
            // Load the "floor2" scene
            SceneManager.LoadScene("garden");
        }
    }
}

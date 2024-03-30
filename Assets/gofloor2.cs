using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gofloor2 : MonoBehaviour
{
    private GameObject player;
    
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with a specific tag or layer if needed
        // For example, if the other object has a "Player" tag
        if (collision.gameObject.CompareTag("Player"))
        {
            Transform playerTransform = player.transform;

            // Set the new position
            Vector2 newPosition = new Vector2(-15.5f, 3.01f);

            // Teleport the player to the new position
            

            // Load the "floor2" scene
            SceneManager.LoadScene("floor2");
            //playerTransform.position = newPosition;
        }
    }
}

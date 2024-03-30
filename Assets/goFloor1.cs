using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goLevel1 : MonoBehaviour
{
    public GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        // Teleport the player to the new position
        
        if (collision.gameObject.CompareTag("Player"))
        {

            Vector2 newPosition = new Vector2(-9.16f, 1.83f);

            Transform playerTransform = player.transform;

           // playerTransform.position = newPosition;
        // Set the new position
            
            // Load the "floor2" scene
            SceneManager.LoadScene("floor1");



        }
    }
}

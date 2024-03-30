using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawngolem : MonoBehaviour
{
    public GameObject enemyPrefab; // Reference to the enemy prefab you want to spawn
    public float spawnInterval = 3f;
    

    void Start()
    {
        // Start spawning enemies after a delay (optional)
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {

        
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            
        
        // Instantiate the enemy at the spawner's position and default rotation

    }
}

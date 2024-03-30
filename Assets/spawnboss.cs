using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnboss : MonoBehaviour
{
    public GameObject enemyPrefab; // Reference to the enemy prefab you want to spawn
    public static float spawnInterval ;
    public int count = 0;
    

    void Start()
    {
        spawnInterval = 3f;
        // Start spawning enemies after a delay (optional)
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {

        
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            count++;
        
        // Instantiate the enemy at the spawner's position and default rotation

    }

}

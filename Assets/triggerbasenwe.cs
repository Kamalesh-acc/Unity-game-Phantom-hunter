using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerbasenwe : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnPoint;
    public float spawnInterval = 2f;
    public int maxEnemies = 5;

    private GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");

        if (player != null)
        {
            StartCoroutine(SpawnEnemyRoutine());
        }
        else
        {
            Debug.LogError("Player not found. Make sure to set the player's tag appropriately.");
        }
    }

    IEnumerator SpawnEnemyRoutine()
    {
        int numEnemiesSpawned = 0;

        while (numEnemiesSpawned < maxEnemies)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(spawnInterval);
            numEnemiesSpawned++;
        }
    }

    void SpawnEnemy()
    {
        if (triggerbase1.istrigger)
        {
            GameObject enemy = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);

            // Get the EnemyFollow script
            EnemyFollow enemyFollow = enemy.GetComponent<EnemyFollow>();

            // Check if the EnemyFollow script is attached
            if (enemyFollow != null)
            {
                // Set the target (player) for the enemy to follow
                enemyFollow.SetTarget(player.transform);
            }
            else
            {
                Debug.LogWarning("EnemyFollow script not found on the enemyPrefab. Make sure to attach the EnemyFollow script.");
            }
        }

    }
}

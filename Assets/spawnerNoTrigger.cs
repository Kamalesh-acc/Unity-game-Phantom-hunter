using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerNoTrigger : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private Transform spawnPosition;
    [SerializeField] private float spawnInterval = 2f; // Interval between spawns in seconds

    private float timer = 2f;
    

    



    private void Update()
    {
        
            timer += Time.deltaTime;
            if (timer >= spawnInterval)
            {
                SpawnObject();
                timer = 0f;
            }
        
    }

    private void SpawnObject()
    {
        Instantiate(objectToSpawn, spawnPosition.position, Quaternion.identity);
    }
}

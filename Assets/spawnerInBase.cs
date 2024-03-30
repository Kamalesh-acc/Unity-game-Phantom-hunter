using UnityEngine;

public class TriggeredInfiniteSpawner2D : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private Transform spawnPosition;
    [SerializeField] private float spawnInterval = 2f; // Interval between spawns in seconds

    private float timer=2f;
    private bool canSpawn = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canSpawn = true;
        }
    }

    

    private void Update()
    {
        if (canSpawn)
        {
            timer += Time.deltaTime;
            if (timer >= spawnInterval)
            {
                SpawnObject();
                timer = 0f;
            }
        }
    }

    private void SpawnObject()
    {
        Instantiate(objectToSpawn, spawnPosition.position, Quaternion.identity);
    }
}

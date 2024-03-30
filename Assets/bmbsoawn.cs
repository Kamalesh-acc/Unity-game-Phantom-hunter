using UnityEngine;

public class bmbsoawn : MonoBehaviour
{
    private float timer = 10f;
    public static int activateSpawn = 0;
    public float spawnInterval = 10f;
    public GameObject bmb;

    void Update()
    {
        timer += Time.deltaTime;

        // Check if it's time to spawn again
        if (activateSpawn == 1 && timer >= spawnInterval)
        {
            
            // Instantiate the bmb GameObject and store the reference to it
            GameObject bmbInstance = Instantiate(bmb, transform.position, Quaternion.identity);

            // Destroy the instantiated bmb GameObject after 3 seconds
            Destroy(bmbInstance, 2.5f);

            timer = 0f;
        }
    }
}

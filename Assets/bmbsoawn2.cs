using UnityEngine;

public class bmbsoawn2 : MonoBehaviour
{
    private float timer = 10f;
    private int activationCount = 0; // Counter to track the number of times activateSpawn is true
    public float spawnInterval = 10f;
    public static int activateSpawn = 0;
    public GameObject bmb;

    void Update()
    {
        timer += Time.deltaTime;

        // Check if it's time to spawn again
        if (activateSpawn == 1 && timer >= spawnInterval)
        {
            // Increment the activation count
            activationCount++;

            // Check if the activation count is odd (skipping every other activation)
            if (activationCount % 2 == 1)
            {
                // Instantiate the bmb GameObject and store the reference to it
                GameObject bmbInstance = Instantiate(bmb, transform.position, Quaternion.identity);

                // Destroy the instantiated bmb GameObject after 2.5 seconds
                Destroy(bmbInstance, 2.5f);

                // Reset the timer
                timer = 0f;
            }
        }
    }
}

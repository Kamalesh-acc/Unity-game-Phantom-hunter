using UnityEngine;

public class bossSpawn1 : MonoBehaviour
{
    public GameObject spawnPrefab;
    
    public Transform position;
    [SerializeField]
    private int spawnCount = 0;
    [SerializeField]
    private int spawnCount2 = 0;
    [SerializeField]
    private int spawnCount3 = 0;
    [SerializeField]
    private int spawnCount4 = 0;
    private float timer = 10f;
    public static int activateSpawn = 0;
    public float spawnInterval = 10f;


    void Update()
    {
        timer += Time.deltaTime;

        // Check if it's time to spawn again
        if (1== activateSpawn && 0 < spawnCount && timer>=spawnInterval)
        {
            Vector3 pos = position.position;
            Instantiate(spawnPrefab, pos, Quaternion.identity);

            

            timer = 0f;
            spawnCount--;
        }

        if (2 == activateSpawn && 0 < spawnCount2 && timer >= spawnInterval)
        {
            Vector3 pos = position.position;
            Instantiate(spawnPrefab, pos, Quaternion.identity);



            timer = 0f;
            spawnCount2--;
        }
        if (3 == activateSpawn && 0 < spawnCount3 && timer >= spawnInterval)
        {
            Vector3 pos = position.position;
            Instantiate(spawnPrefab, pos, Quaternion.identity);



            timer = 0f;
            spawnCount3--;
        }
        if (4 == activateSpawn && 0 < spawnCount4 && timer >= spawnInterval)
        {
            Vector3 pos = position.position;
            Instantiate(spawnPrefab, pos, Quaternion.identity);



            timer = 0f;
            spawnCount4--;
        }
    }
}

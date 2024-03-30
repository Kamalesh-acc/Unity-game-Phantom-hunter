using UnityEngine;

public class bossfire3Sub : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public GameObject bulletPrefab; // Prefab of the bullet

    public Transform bulletSpawnPoint; // Point from where the bullets will spawn
    public static float bulletSpeed = 10f; // Speed of the bullet
    public static float shootInterval = 1f; // Interval between shots
    private float shootTimer = 0f; // Timer to keep track of shooting interval
    private GameObject objectToDisplayInstance;
    public static bool subSpawn = false;
    [SerializeField]
    public GameObject objectToDisplayPrefab;
    private bool check = true;// Prefab of the object to display
    

    private void Start()
    {
        bulletSpeed = 10f;
        shootInterval = 1f;
    }

    void Update()
    {
        if (BossHealth3.currentHealth <= 0)
        {
            
            Destroy(objectToDisplayInstance);


        }
        if (subSpawn == true)
        {
            if(BossHealth3.currentHealth < 30)
{
                bulletSpeed = 25f;
                shootInterval = 0.4f;
            }
            if (BossHealth3.currentHealth < 75 && check == true)
            {
                
                objectToDisplayInstance = Instantiate(objectToDisplayPrefab, transform.position, Quaternion.identity);
                check = false;
                
            }

            // Check if the player reference is assigned
            

            // Calculate direction towards the player
            Vector2 directionToPlayer = (player.position - bulletSpawnPoint.position).normalized;

            // Shooting logic
            shootTimer += Time.deltaTime;
            if (shootTimer >= shootInterval)
            {
                ShootBullet(directionToPlayer);
                shootTimer = 0f;
            }
        }
        
    }

    void ShootBullet(Vector2 direction)
    {
        // Instantiate bullet prefab
        GameObject bullet;
        bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);

        // Get Rigidbody2D component of the bullet and shoot it towards the player
        Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();

        // Check if Rigidbody2D component exists
        if (bulletRB == null)
        {
            Debug.LogError("Rigidbody2D component not found on the bullet prefab.");
            return;
        }

        // Apply velocity to the bullet Rigidbody
        bulletRB.velocity = direction * bulletSpeed;
    }
}

using UnityEngine;

public class bossfire3 : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public GameObject bulletPrefab; // Prefab of the bullet
    public GameObject new1BulletPrefab; // New bullet prefab
    public GameObject new2bulletPrefab; // New bullet prefab
    public Transform bulletSpawnPoint; // Point from where the bullets will spawn
    public static float bulletSpeed = 10f; // Speed of the bullet
    public static float shootInterval = 1f; // Interval between shots
    private float shootTimer = 0f; // Timer to keep track of shooting interval


    private void Start()
    {
        bulletSpeed = 10f;
        shootInterval = 1f;
    }

    void Update()
    {
        // Check if the player reference is assigned
        if (player == null)
        {
            
            return;
        }

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

    void ShootBullet(Vector2 direction)
    {
        // Instantiate bullet prefab
        GameObject bullet;
        if (BossHealth3.currentHealth <= 150 && BossHealth3.currentHealth >= 100)
        { bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity); }
        else if (BossHealth3.currentHealth <= 100 && BossHealth3.currentHealth >= 75)
        {
            bullet = Instantiate(new1BulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
        }
        else
        {
            bullet = Instantiate(new2bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
        }

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

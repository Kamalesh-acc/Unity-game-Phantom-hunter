using UnityEngine;

public class bossbullet1 : MonoBehaviour
{
    public GameObject destructionEffect;
    public float destructionDuration = 1.0f;
    public float bulletSpeed = 5f; // Adjust bullet speed as needed
    private Transform player; // Reference to the player's transform

    void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null)
        {
            player = playerObject.transform;

            // Calculate direction to the player
            Vector3 direction = player.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            // Rotate the bullet to face the player
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    void Update()
    {
        // Move the bullet forward in its local space
        transform.Translate(Vector2.right * bulletSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the bullet collides with an object tagged as "Player"
        if (other.CompareTag("Player"))
        {
            // Instantiate the destruction effect
            if (destructionEffect != null)
            {
                GameObject effectInstance = Instantiate(destructionEffect, transform.position, Quaternion.identity);

                // Destroy the destruction effect GameObject after a specified duration
                Destroy(effectInstance, destructionDuration);
            }

            // Destroy the bullet GameObject
            Destroy(gameObject);
        }
        else if (other.CompareTag("Bullet"))
        {
            // Destroy both the bullet and the other bullet if they collide
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}

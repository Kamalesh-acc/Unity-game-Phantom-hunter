using UnityEngine;

public class bossbullet3 : MonoBehaviour
{
    public GameObject destructionEffect;
    public float destructionDuration = 1.0f;
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the bullet collides with an object tagged as "Player"
        if (other.CompareTag("Player"))
        {
            GameObject effectInstance = Instantiate(destructionEffect, transform.position, Quaternion.identity);

            // Destroy the destruction effect GameObject after a specified duration
            Destroy(effectInstance, destructionDuration);
            Destroy(gameObject);

        }
        if (other.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}

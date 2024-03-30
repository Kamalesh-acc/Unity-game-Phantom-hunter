using UnityEngine;

public class bulletinBossfight : MonoBehaviour
{
    public GameObject destructionEffect;
    public float destructionDuration = 1.0f;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the bullet collides with an object tagged as "Player"
        if (other.CompareTag("ghost2"))
        {
           
            Destroy(gameObject);

        }
        if (other.CompareTag("Bullet1"))
        {
            
            Destroy(gameObject);
            
        }
        if (other.CompareTag("boss"))
        {
            GameObject effectInstance = Instantiate(destructionEffect, transform.position, Quaternion.identity);

            // Destroy the destruction effect GameObject after a specified duration
            Destroy(effectInstance, destructionDuration);
        }
        if (other.CompareTag("Bullet2"))
        {
            
            Destroy(gameObject);
            
        }
        if (other.CompareTag("ghostNormal"))
        {
            
            Destroy(gameObject);
        }
        

    }
}

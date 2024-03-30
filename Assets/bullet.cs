using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject destructionEffect;
    public GameObject destructionEffectghost;
    public float destructionDuration = 1.0f; // Adjust this value to control the duration of the destruction effect

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Instantiate the destruction effect
        



        if (collision.gameObject.CompareTag("invisible"))
        {
            GameObject effectInstance = Instantiate(destructionEffect, transform.position, Quaternion.identity);

            // Destroy the destruction effect GameObject after a specified duration
            Destroy(effectInstance, destructionDuration);
            Destroy(gameObject);

        }
        if (!collision.gameObject.CompareTag("invisible"))
        {
            GameObject effectInstance = Instantiate(destructionEffectghost, transform.position, Quaternion.identity);

            // Destroy the destruction effect GameObject after a specified duration
            Destroy(effectInstance, destructionDuration);
            Destroy(gameObject);

        }





        

        // Destroy the bullet GameObject
        

        // Check if the collision involves the ghostNormal prefab
    }
}

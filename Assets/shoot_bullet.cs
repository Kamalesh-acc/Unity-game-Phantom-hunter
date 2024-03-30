using UnityEngine;

public class shoot_bullet : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab1;
    public GameObject bulletPrefab2;
    public GameObject bulletPrefab3;
    float fireRate = 0.2f;
    private float lastFireTime = 0f;
    public AudioSource bulletSound;
    public AudioSource bulletSound2;
    public AudioSource bulletSound3;
    // Update is called once per frame
    void Update()
    {
        
        if (power2.power == 1)
        {
            if (Input.GetButtonDown("Fire1") && Time.time > lastFireTime + fireRate)
            {
                // Update the last fire time
                lastFireTime = Time.time;
                bulletSound.Play();
                // Shoot the bullet
                Shoot();

            }
        }
        else 
        {
            if (Input.GetButton("Fire1") && Time.time > lastFireTime + fireRate)
            {
                // Update the last fire time
                lastFireTime = Time.time;
                if (power2.power == 2)
                {
                    bulletSound2.Play();
                }
                else
                {
                    bulletSound3.Play();    
                }
                
                // Shoot the bullet
                Shoot();
            }
        }

    }

    void Shoot()
    {
        GameObject bulletInstance;
        if (power2.power == 1) { bulletInstance = Instantiate(bulletPrefab1, firePoint.position, firePoint.rotation);}
        else if(power2.power == 2) { bulletInstance = Instantiate(bulletPrefab2, firePoint.position, firePoint.rotation); }
        else { bulletInstance = Instantiate(bulletPrefab3, firePoint.position, firePoint.rotation); }

        
        
        // Get the Rigidbody2D component of the bullet
        Rigidbody2D rb = bulletInstance.GetComponent<Rigidbody2D>();

        // Apply a random rotation to the bullet
        rb.transform.Rotate(Random.Range(-10, 10), Random.Range(-10, 10), 0);

        // Apply force to the bullet in the direction of the fire point's up vector
        rb.AddForce(firePoint.up * 15, ForceMode2D.Impulse);
    }
}

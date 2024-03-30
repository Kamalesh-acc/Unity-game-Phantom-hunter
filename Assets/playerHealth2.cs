using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealth2 : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    public GameObject dieEffect;
    public GameObject dmgEffect;
    public float dieDuration = 1.0f;
    public float dmgDuration = 1.0f;
    public healthbar healthbar;
    public float healthbarDuration = 1.0f;
    private int checker = 1;
    public bool playerAlive = true;

    

    public GameObject gameOverPlayer;

    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (power2.power == 2 && checker == 1)
        {
            Debug.Log("Entered");
            maxHealth = 20;

            currentHealth = maxHealth;
            healthbar.SetMaxHealth(maxHealth);
            healthbar.SetHealth(currentHealth);

            checker = 2;
            Debug.Log(checker);

        }
        if (power2.power == 3 && checker == 2)
        {
            maxHealth = 30;
            currentHealth = maxHealth;
            healthbar.SetMaxHealth(maxHealth);
            healthbar.SetHealth(currentHealth);

            checker = 3;
        }
        if (currentHealth <= 0 && playerAlive)
        {
            gameOverPlayer.SetActive(false);
            
            GameObject effectInstance = Instantiate(dieEffect, transform.position, Quaternion.identity);



            Destroy(effectInstance, dieDuration);

            playerAlive = false;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet1"))
        {
            TakeDamage(2);
            // Destroy the bullet on impact
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Bullet2"))
        {
            TakeDamage(3);
            // Destroy the bullet on impact
            Destroy(other.gameObject);
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the enemy is hit by a bullet
        if (collision.gameObject.CompareTag("ghostNormal"))
        {
            TakeDamage(1);
            // Destroy the bullet on impact
        }
        if (collision.gameObject.CompareTag("ghost2"))
        {
            TakeDamage(2);
            // Destroy the bullet on impact
        }
        if (collision.gameObject.CompareTag("ghost3"))
        {
            TakeDamage(3);
            // Destroy the bullet on impact
        }
        if (collision.gameObject.CompareTag("bmb"))
        {
            TakeDamage(3);
            // Destroy the bullet on impact
        }

    }

    void TakeDamage(int damage)
    {
        GameObject effectInstance = Instantiate(dmgEffect, transform.position, Quaternion.identity);
        effectInstance.transform.parent = transform;
        // Destroy the destruction effect GameObject after a specified duration
        Destroy(effectInstance, dmgDuration);

        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
    }
}


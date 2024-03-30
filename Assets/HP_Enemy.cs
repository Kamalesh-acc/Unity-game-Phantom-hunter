using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_Enemy : MonoBehaviour
{
    public int maxHealth = 5;
    private int currentHealth;
    public GameObject destructionEffect;
    public float destructionDuration = 1.0f;

    // Flag to indicate if the enemy has died
    public bool isDead = false;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (currentHealth <= 0 && !isDead)
        {
            isDead = true; // Set the flag to true
            GameObject effectInstance = Instantiate(destructionEffect, transform.position, Quaternion.identity);
            Destroy(effectInstance, destructionDuration);
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(1);
            Destroy(collision.gameObject); // Destroy the bullet on impact
        }
        if (collision.gameObject.CompareTag("playerBullet2"))
        {
            TakeDamage(2);
            Destroy(collision.gameObject); // Destroy the bullet on impact
        }
        if (collision.gameObject.CompareTag("playerBullet3"))
        {
            TakeDamage(3);
            Destroy(collision.gameObject); // Destroy the bullet on impact
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(1);
            Destroy(other.gameObject);
        }
    }

    void TakeDamage(int damage)
    {
        // Reduce the enemy's health
        currentHealth -= damage;
    }
}

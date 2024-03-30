using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using Random = UnityEngine.Random;

public class HP_enemy : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        // Check if the enemy is defeated
       /* if (currentHealth <= 0)
        {
            Destroy(gameObject);
            score.currentScore += 10;
        }*/
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the enemy is hit by a bullet
        if (collision.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(20);
            Destroy(collision.gameObject); // Destroy the bullet on impact
        }
    }

    void TakeDamage(int damage)
    {
        // Reduce the enemy's health
        currentHealth -= damage;
    }
}

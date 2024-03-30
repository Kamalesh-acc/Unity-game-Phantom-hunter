using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth3 : MonoBehaviour
{
    public int maxHealth = 100;
    [SerializeField]
    public int cHealth;
    public static int currentHealth;
    public Animator spawnAnime;

    public bool spawnAnimationTriggered = true;
    public bool spawnAnimationTriggered4 = true;
    public bool spawnAnimationTriggered3 = true;
    public bool spawnAnimationTriggered2 = true;
    public bool spawnAnimationTriggered5 = true;
    public bool spawnAnimationTriggered6 = true;

    public float delay = 0.5f;
    public float delayDeath = 3f;
    public bosshealthbar3 healthbar1;
    public GameObject newBulletPrefab;

    

    void Start()
    {
        currentHealth = maxHealth;
        healthbar1.SetMaxHealth(maxHealth);

        // Get the bossfire script component from the same GameObject

    }

    void Update()
    {
        cHealth = currentHealth;
        if (currentHealth <= 0)
        {
            spawnAnime.SetBool("todie", true);
            Destroy(gameObject, delayDeath);


            
        }
        if (currentHealth < 30 && spawnAnimationTriggered6)
        {
            spawnAnime.SetBool("spawn", true);
            spawnAnimationTriggered6 = false;
            Invoke("offAnime", delay);


            bossfire3.bulletSpeed = 25f;
            bossfire3.shootInterval = 0.4f;
            bossspawnanim3.activateSpawnAnim = 2;
        }
        
        if (currentHealth < 75 && spawnAnimationTriggered5)
        {
            spawnAnime.SetBool("spawn", true);
            spawnAnimationTriggered5 = false;
            Invoke("offAnime", delay);

            //no need of fire rate
            bossfire3Sub.subSpawn= true;
            bmbsoawn.activateSpawn = 1;
            bmbsoawn2.activateSpawn = 1;
            
        }
        if (currentHealth <= 85 && spawnAnimationTriggered4)
        {

            spawnAnime.SetBool("spawn", true);
            spawnAnimationTriggered4 = false;
            Invoke("offAnime", delay);

            bossfire3.bulletSpeed = 19f;
            bossfire3.shootInterval = 0.4f;
            bossspawnanim3.activateSpawnAnim = 1;
            bossSpawn3.activateSpawn = 4;
        }
        if (currentHealth <= 100 && spawnAnimationTriggered3)
        {


            spawnAnime.SetBool("spawn", true);
            spawnAnimationTriggered3 = false;
            Invoke("offAnime", delay);

            bossfire3.bulletSpeed = 16f;
            bossfire3.shootInterval = 0.4f;
            bossspawnanim3.activateSpawnAnim = 1;
            bossSpawn3.activateSpawn = 3;
        }
        if (currentHealth <= 120 & spawnAnimationTriggered2)
        {

            spawnAnime.SetBool("spawn", true);
            spawnAnimationTriggered2 = false;
            Invoke("offAnime", delay);

            bossfire3.bulletSpeed = 14f;
            bossfire3.shootInterval = 0.6f;
            bossspawnanim3.activateSpawnAnim = 1;
            bossSpawn3.activateSpawn = 2;
        }
        if (currentHealth <= 140 && spawnAnimationTriggered)
        {


            spawnAnime.SetBool("spawn", true);
            spawnAnimationTriggered = false;
            Invoke("offAnime", delay);

            bossfire3.bulletSpeed = 12f;
            bossfire3.shootInterval = 0.8f;
            bossspawnanim3.activateSpawnAnim = 1;
            bossSpawn3.activateSpawn = 1;
        }
    }
    void offAnime()
    {
        spawnAnime.SetBool("spawn", false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(1);
            Destroy(other.gameObject);
        }
    }


    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar1.SetHealth(currentHealth);
    }


}

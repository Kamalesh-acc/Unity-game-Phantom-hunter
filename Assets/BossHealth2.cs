using UnityEngine;

public class BossHealth2 : MonoBehaviour
{
    public int maxHealth = 100;
    public static int currentHealth;
    public Animator spawnAnime;

    public bool spawnAnimationTriggered = true;
    public bool spawnAnimationTriggered4 = true;
    public bool spawnAnimationTriggered3 = true;
    public bool spawnAnimationTriggered2 = true;

    public float delay = 0.5f;
    public float delayDeath = 3f;
    public bosshealthbar2 healthbar1;
    public GameObject newBulletPrefab; // Reference to the new bullet prefab for below 50 health

    // Reference to the bossfire script instance

    void Start()
    {
        currentHealth = maxHealth;
        healthbar1.SetMaxHealth(maxHealth);

        // Get the bossfire script component from the same GameObject

    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            spawnAnime.SetBool("todie", true);
            Destroy(gameObject, delayDeath);
        }


        if (currentHealth <= 25 && spawnAnimationTriggered4)
        {

            spawnAnime.SetBool("tospawn", true);
            spawnAnimationTriggered4 = false;
            Invoke("offAnime", delay);

            bossfire2.bulletSpeed = 19f;
            bossfire2.shootInterval = 0.4f;
            bossspawnanim2.activateSpawnAnim = 1;
            bossSpawn2.activateSpawn = 4;
        }
        if (currentHealth <= 50 && spawnAnimationTriggered3)
        {


            spawnAnime.SetBool("tospawn", true);
            spawnAnimationTriggered3 = false;
            Invoke("offAnime", delay);

            bossfire2.bulletSpeed = 17f;
            bossfire2.shootInterval = 0.4f;
            bossspawnanim2.activateSpawnAnim = 1;
            bossSpawn2.activateSpawn = 3;
        }
        if (currentHealth <= 75 && spawnAnimationTriggered2)
        {
            
            spawnAnime.SetBool("tospawn", true);
            spawnAnimationTriggered2 = false;
            Invoke("offAnime", delay);

            bossfire2.bulletSpeed = 14f;
            bossfire2.shootInterval = 0.5f;
            bossspawnanim2.activateSpawnAnim = 1;
            bossSpawn2.activateSpawn = 2;
        }
        if (currentHealth <= 90 && spawnAnimationTriggered)
        {


            spawnAnime.SetBool("tospawn", true);
            spawnAnimationTriggered = false;
            Invoke("offAnime", delay);

            bossfire2.bulletSpeed = 12f;
            bossfire2.shootInterval = 0.8f;
            bossspawnanim2.activateSpawnAnim = 1;
            bossSpawn2.activateSpawn = 1;
        }
    }

    void offAnime()
    {
        spawnAnime.SetBool("tospawn", false);
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

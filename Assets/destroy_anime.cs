using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{

    public GameObject destructionEffect; // Reference to the object to spawn upon destruction
    public float destroyTime = 3f;

    void Start()
    {
        // Invoke the DestroyBullet method after destroyTime seconds
        Invoke("DestroyBullet", destroyTime);
    }

    void DestroyBullet()
    {
        SpawnDestructionEffect();
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        SpawnDestructionEffect();
        Destroy(gameObject);
    }

    void SpawnDestructionEffect()
    {
        // Check if the destructionEffect prefab is assigned

        // Instantiate the destruction effect at the bullet's position
        Instantiate(destructionEffect, transform.position, Quaternion.identity);

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoryAnimation : MonoBehaviour
{
    public GameObject destructionEffect; // Reference to the object to spawn upon destruction
    public float destroyTime = 1.5f;

    void Start()
    {
        // Invoke the DestroyBullet method after destroyTime seconds
        Invoke("Destroy", destroyTime);
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
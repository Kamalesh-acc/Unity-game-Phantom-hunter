using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class minionAnime1 : MonoBehaviour
{
    public float delay = 10f;

    void Start()
    {
        // Invoke the DestroyObject method after 'delay' seconds
        Invoke("DestroyObject", delay);
    }

    void DestroyObject()
    {
        // Destroy the gameObject this script is attached to
        Destroy(gameObject);
    }

}

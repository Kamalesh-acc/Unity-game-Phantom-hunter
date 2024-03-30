using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDieGhost : MonoBehaviour
{
    public AudioSource ghostDeathAudio;

    // Reference to the HP_Enemy script
    public HP_Enemy enemyHealth;

    void Start()
    {
        // Get the HP_Enemy script attached to the same GameObject
        enemyHealth = GetComponent<HP_Enemy>();
    }

    void Update()
    {
        // Check if the enemy has died
        if (enemyHealth != null && enemyHealth.isDead)
        {
            // Play the enemy death sound
            ghostDeathAudio.Play();
        }
    }
}

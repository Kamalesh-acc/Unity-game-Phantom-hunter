using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class victory : MonoBehaviour
{
    public AudioSource victorySound;
    private bool hasPlayedVictorySound = false;
    

    void Update()
    {
        if (!hasPlayedVictorySound && BossHealth3.currentHealth <= 0 && BossHealth.currentHealth <= 0 && BossHealth2.currentHealth <= 0)
        {
            audiobg.stopMusic=true;
            victorySound.Play();
            hasPlayedVictorySound = true; // Set the flag to true to indicate the sound has been played
            StartCoroutine(LoadSceneAfterDelay(6f));
        }
    }
    IEnumerator LoadSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("victory");
    }
}


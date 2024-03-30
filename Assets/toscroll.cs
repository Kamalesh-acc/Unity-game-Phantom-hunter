using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class toscroll : MonoBehaviour
{
    public AudioSource keySound;
    // Start is called before the first frame update
    public void play()
    {
        keySound.Play();
        // Get the current active scene
        Scene currentScene = SceneManager.GetActiveScene();

        // Load the 'floor1' scene additively
        SceneManager.LoadScene("floor1", LoadSceneMode.Additive);
        SceneManager.LoadScene("starter scene", LoadSceneMode.Additive);

        StartCoroutine(UnloadCurrentScene(currentScene));
    }

    IEnumerator UnloadCurrentScene(Scene sceneToUnload)
    {
        // Wait for a short delay to ensure the next scene is loaded
        yield return new WaitForSeconds(0.1f);

        // Unload the current scene
        SceneManager.UnloadSceneAsync(sceneToUnload);


    }
}

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections; // Add this line to include the System.Collections namespace

public class togame : MonoBehaviour
{
    public void play()
    {
        // Get the current active scene
        Scene currentScene = SceneManager.GetActiveScene();

        // Load the 'floor1' scene additively
        SceneManager.LoadScene("scroll", LoadSceneMode.Additive);
        

        // Unload the current scene after a short delay
        StartCoroutine(UnloadCurrentScene(currentScene));
    }

    IEnumerator UnloadCurrentScene(Scene sceneToUnload)
    {
        // Wait for a short delay to ensure the next scene is loaded
        yield return new WaitForSeconds(0.1f);

        // Unload the current scene
        SceneManager.UnloadSceneAsync(sceneToUnload);


    }

    public void quit()
    {
        Application.Quit();
    }
}



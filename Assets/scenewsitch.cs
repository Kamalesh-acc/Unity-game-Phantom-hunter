using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneSwitcher : MonoBehaviour
{
    // The name of the scene to switch to
    public string sceneName;

    // The delay before switching to the next scene (in seconds)
    public float delayInSeconds = 4f;

    private void Start()
    {
        // Start the coroutine to switch scenes after delayInSeconds
        StartCoroutine(SwitchSceneAfterDelay());
    }

    IEnumerator SwitchSceneAfterDelay()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delayInSeconds);

        // Load the next scene
        SceneManager.LoadScene("bossFight");
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    // This method is called before the first frame update
    void Start()
    {
        // Ensure that this GameObject persists across scene changes



        Scene currentScene = SceneManager.GetActiveScene();
        if (!(currentScene.name == "bossFight"))
        {

            DontDestroyOnLoad(gameObject);
        }
    }
    private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if ((currentScene.name == "bossFight" || currentScene.name == "transition"))
        {

            Destroy(gameObject);
        }
    }
}

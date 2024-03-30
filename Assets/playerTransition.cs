using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance; // Singleton instance

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Ensure this GameObject persists across scenes
        }
        else
        {
            Destroy(gameObject); // If another instance exists, destroy this one
        }
    }

    // Method to set the player's position
    public void SetPosition(Vector3 position)
    {
        transform.position = position;
    }
}

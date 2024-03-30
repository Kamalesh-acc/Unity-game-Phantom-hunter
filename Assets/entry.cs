using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class entry : MonoBehaviour
{
    void Update()
    {
        // Check if the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Load the "floor1" scene
            SceneManager.LoadScene("floor1");
        }
    }
}

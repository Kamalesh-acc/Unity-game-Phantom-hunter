using UnityEngine;

public class rotation : MonoBehaviour
{
    public float rotationSpeed = 50f;

    void Update()
    {
        // Rotate the GameObject around its Z-axis
        transform.rotation *= Quaternion.Euler(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour

{
    
    public Transform player;
    public Vector3 offset = new Vector3(0f, 0f, -10f);
    public float smoothSpeed = 5f;

    void LateUpdate()
    {
        if (player != null)
        {
            // Calculate the desired position of the camera
            Vector3 desiredPosition = player.position + offset;

            // Use Mathf.Lerp to smoothly interpolate between the current position and desired position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

            // Update the camera's position
            transform.position = smoothedPosition;
        }
    }
}



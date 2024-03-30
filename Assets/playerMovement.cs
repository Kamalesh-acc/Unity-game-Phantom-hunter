using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 5f;
    
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Freeze rotation on Z axis so only the mouse can rotate the player. This will prevent other physics object rotating it. We can unlock this if we ever want to throw the player or similar.
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        // Handle the movement in FixedUpdate as it is physics related
        HandleMovement();
        HandleRotation();
    }

    void HandleMovement()
    {
        // A and D
        float horizontalAxisMovement = Input.GetAxis("Horizontal");
        // W and S
        float verticalAxisMovement = Input.GetAxis("Vertical");

        // Create a movement vector out of the axis of input
        Vector2 newMovementVector = new Vector2(horizontalAxisMovement, verticalAxisMovement);

        // Apply the movement vector direction with the speed and apply it instantly. If an axis is 0 there will be no movement
        rb.velocity = newMovementVector * speed;
    }

    void HandleRotation()
    {
        Vector2 mousePositionInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Get the distance between the player and the mouse. This is how we build the two sides of the triangle to get the angle to rotate. Atan2 is confusing 😦
        mousePositionInWorld.x = mousePositionInWorld.x - transform.position.x;
        mousePositionInWorld.y = mousePositionInWorld.y - transform.position.y;

        float angleToRotate = Mathf.Atan2(mousePositionInWorld.y, mousePositionInWorld.x) * Mathf.Rad2Deg;
        rb.rotation = angleToRotate-90;
    }
}

 
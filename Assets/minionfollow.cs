using UnityEngine;

public class minionfollow : MonoBehaviour
{
    public float moveSpeed = 2f; // Adjust the speed as needed
    private Transform target; // The target to follow (player)
    private SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer component
    private float delayTimer = 0f;
    public float delay = 5f;

    private bool canMove = false;

    void Start()
    {
        // Find the player GameObject and set it as the target
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            target = player.transform;
        }
        else
        {
            Debug.Log("Player not found. Make sure to set the player's tag appropriately.");
        }

        // Get the SpriteRenderer component
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Increment the delay timer
        delayTimer += Time.deltaTime;

        // Check if the delay timer exceeds 5 seconds
        if (delayTimer >= delay)
        {
            canMove = true; // Allow movement after 5 seconds
        }

        // Check if the target (player) is set and if movement is allowed
        if (target != null && canMove)
        {
            // Move towards the target (player)
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);

            // Flip the sprite based on the direction to the player
            if (target.position.x < transform.position.x)
            {
                // Player is to the left of the enemy, flip the sprite
                spriteRenderer.flipX = true;
            }
            else
            {
                // Player is to the right of the enemy, don't flip the sprite
                spriteRenderer.flipX = false;
            }
        }
    }
}

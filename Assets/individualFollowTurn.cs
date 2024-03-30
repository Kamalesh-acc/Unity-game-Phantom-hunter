using UnityEngine;

public class individualFollowTurn : MonoBehaviour
{
    public float moveSpeed = 2f; // Adjust the speed as needed
    private Transform target; // The target to follow (player)
    private SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer component

    void Start()
    {
        // Find the player GameObject and set it as the target
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            target = player.transform;
        }
        

        // Get the SpriteRenderer component
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Check if the target (player) is set
        if (target != null)
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

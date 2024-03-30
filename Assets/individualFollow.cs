using UnityEngine;

public class individualFollow : MonoBehaviour
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

            
        }
    }
}

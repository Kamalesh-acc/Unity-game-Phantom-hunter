using UnityEngine;

public class playerFollow : MonoBehaviour
{
    public float moveSpeed = 2f;
    private Transform target;
    private bool canMove = false;

    private void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null)
        {
            target = playerObject.transform;
            StartCoroutine(EnableMovementAfterDelay(2.0f));
        }
        
    }

    void Update()
    {
        if (!canMove || target == null) return;

        // Calculate the direction to the player
        Vector3 directionToPlayer = target.position - transform.position;

        // Move towards the player
        transform.position += directionToPlayer.normalized * moveSpeed * Time.deltaTime;

        // Flip the sprite on the X-axis based on the player's position
        float facingDirection = Mathf.Sign(directionToPlayer.x);
        transform.localScale = new Vector3(facingDirection, transform.localScale.y, transform.localScale.z);
    }

    private System.Collections.IEnumerator EnableMovementAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        canMove = true;
    }
}

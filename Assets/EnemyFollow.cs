using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float moveSpeed = 2f; // Adjust the speed as needed
    private Transform target; // The target to follow (player)

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    void Update()
    {
        // Check if the target (player) is set
        if (target != null)
        {
            // Move towards the target (player)
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);

            // Rotate towards the target (player) - Optional
            // Vector3 direction = (target.position - transform.position).normalized;
            // Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, direction.y, 0f));
            // transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotationSpeed);
        }
    }
}

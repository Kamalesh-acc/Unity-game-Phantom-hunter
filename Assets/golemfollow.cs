using UnityEngine;

public class GolemFollow : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Transform target;
    private bool canMove = false;

    void Start()
    {
        Invoke("EnableMovement", 1.5f);
    }

    void Update()
    {
        if (triggerf3golem.istrigger)
        {
            Destroy(gameObject);
            return;
        }

        // Search for the player object each frame
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null)
        {
            target = playerObject.transform;
        }

        if (canMove && target != null)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
    }

    void EnableMovement()
    {
        canMove = true;
    }
}

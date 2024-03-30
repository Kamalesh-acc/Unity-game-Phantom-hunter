using UnityEngine;

public class AnimationSpeedController : MonoBehaviour
{
    public Animator animator;
    public string animationName; // Name of the animation you want to control
    public float newSpeed = 0.5f; // Adjust this value to change the animation speed

    void Start()
    {
        // Get reference to the Animator component
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Set the speed of the specified animation
        animator.SetFloat(animationName + "Speed", newSpeed);
    }
}

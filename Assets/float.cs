using UnityEngine;

public class FloaterWithShimmeringEffect : MonoBehaviour
{
    public float floatSpeed = 1f;
    public float floatHeight = 0.5f;
    public Color baseColor = Color.white;
    public Color shimmerColor = Color.blue;
    public float shimmerSpeed = 1f;
    public float pulseSpeed = 1f;
    public float minScale = 0.8f;
    public float maxScale = 1.2f;

    private Vector2 startPosition;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        startPosition = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Calculate the vertical offset using Mathf.Sin to create a floating effect
        float offsetY = Mathf.Sin(Time.time * floatSpeed) * floatHeight;

        // Update the position of the GameObject with the floating offset
        transform.position = startPosition + new Vector2(0f, offsetY);

        float pulseFactor = Mathf.Lerp(minScale, maxScale, Mathf.PingPong(Time.time * pulseSpeed, 1f));
        transform.localScale = new Vector3(pulseFactor, pulseFactor, 1f);

        // Calculate shimmer effect using color animation
        float shimmerFactor = Mathf.PingPong(Time.time * shimmerSpeed, 1f);
        Color newColor = Color.Lerp(baseColor, shimmerColor, shimmerFactor);
        spriteRenderer.color = newColor;
    }
}

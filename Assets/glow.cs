using UnityEngine;

public class GlowingEffect : MonoBehaviour
{
    public float glowIntensity = 1f;
    public float glowSpeed = 1f;

    private Material material;
    private float glowOffset;

    void Start()
    {
        // Get the material of the object
        Renderer renderer = GetComponent<Renderer>();
        material = renderer.material;
    }

    void Update()
    {
        // Calculate the glow offset based on time
        glowOffset = Mathf.Sin(Time.time * glowSpeed) * glowIntensity;

        // Set the emission color of the material
        Color finalColor = Color.white * Mathf.LinearToGammaSpace(glowOffset);
        material.SetColor("_EmissionColor", finalColor);
    }
}

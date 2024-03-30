using UnityEngine;

public class soundPlayer : MonoBehaviour
{
    public AudioSource keySound;
    public AudioSource magicSound;

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("key"))
        {
            
            keySound.Play();
        }
        if (collision.gameObject.CompareTag("magic"))
        {
            
            magicSound.Play();
        }
    }
}

using UnityEngine;

public class doorsound : MonoBehaviour
{
    public AudioSource keySound;
    

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("door")&& door.k1==1)
        {

            keySound.Play();
        }
        if (collision.gameObject.CompareTag("door2") && door2.k2 == 1)
        {

            keySound.Play();
        }
        if (collision.gameObject.CompareTag("door3") && door3.k3 == 1)
        {

            keySound.Play();
        }
        if (collision.gameObject.CompareTag("door4") && door4.k4 == 1)
        {

            keySound.Play();
        }
        if (collision.gameObject.CompareTag("door5") && door5.k5 == 1)
        {

            keySound.Play();
        }
        if (collision.gameObject.CompareTag("door6") && door6.k6 == 1)
        {

            keySound.Play();
        }
        if (collision.gameObject.CompareTag("door7") && door7.k7 == 1)
        {

            keySound.Play();
        }
        if (collision.gameObject.CompareTag("door8") && door8.k8 == 1)
        {

            keySound.Play();
        }
        if (collision.gameObject.CompareTag("door9") && door9.k9 == 1)
        {

            keySound.Play();
        }
        if (collision.gameObject.CompareTag("door10") && door10.k10 == 1)
        {

            keySound.Play();
        }



    }
}

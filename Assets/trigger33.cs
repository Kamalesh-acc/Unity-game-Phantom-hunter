using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger33 : MonoBehaviour
{
    public static bool istrigger = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            istrigger = true;

        }
    }

}

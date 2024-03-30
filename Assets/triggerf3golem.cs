using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerf3golem : MonoBehaviour
{
    public static bool istrigger = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        istrigger = true;
    }
}

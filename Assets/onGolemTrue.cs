using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onGolemTrue : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        triggerf3golem.istrigger = false;
    }
}

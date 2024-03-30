using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pwerr2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        if (power2.power>= 2)
        {
            Destroy(gameObject);
        }
    }
}

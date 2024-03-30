using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pwerr3 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        if (power2.power == 3)
        {
            Destroy(gameObject);
        }
    }
}

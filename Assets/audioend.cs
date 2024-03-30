using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioend : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource bgm;
    
    private void Start()
    {
        bgm.Play();

    }
}

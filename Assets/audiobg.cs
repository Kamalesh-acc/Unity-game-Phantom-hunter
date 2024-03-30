using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiobg : MonoBehaviour
{

    public AudioSource bgm;
    public static bool stopMusic=false;
    public static bool stop = true;
    private void Start()
    {
        bgm.Play(); 
        
    }
    public void Update()
    {
        if (stopMusic && stop) { bgm.Stop(); stop = false; }
    }

}

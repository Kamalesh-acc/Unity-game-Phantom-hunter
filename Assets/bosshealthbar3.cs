using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bosshealthbar3 : MonoBehaviour
{

    public Slider slider;

    public Image fill;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;


    }

    public void SetHealth(int health)
    {
        slider.value = health;

    }

}
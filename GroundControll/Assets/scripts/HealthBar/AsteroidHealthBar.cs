using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsteroidHealthBar : MonoBehaviour
{
    public Slider AsteroidHPSlider;
    

    public void SetMaxHealth(int health)
    {
        AsteroidHPSlider.maxValue = health;
        AsteroidHPSlider.value = health;
    }

    public void SetHealth(int health)
    {
        AsteroidHPSlider.value = health;
    }
}

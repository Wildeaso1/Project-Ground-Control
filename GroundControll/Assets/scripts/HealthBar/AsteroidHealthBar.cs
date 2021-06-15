using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsteroidHealthBar : MonoBehaviour
{
    public Slider AsteroidHPSlider;
    

    public void SetMaxHealth(float health)
    {
        AsteroidHPSlider.maxValue = health;
        AsteroidHPSlider.value = health;
    }

    public void SetHealth(float health)
    {
        AsteroidHPSlider.value = health;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class AsteroidHealthBar : MonoBehaviour
{
    public Slider AsteroidHPSlider;
    private float TargetHealth;
    private float SlidingTime = 0.2f;
    public void SetMaxHealth(float health)
    {
        AsteroidHPSlider.maxValue = health;
        AsteroidHPSlider.value = health;
    }

    public void SetTargetHealth(float health)
    {
        TargetHealth = health;
        AsteroidHPSlider.DOValue(TargetHealth, SlidingTime);
        
    }
}

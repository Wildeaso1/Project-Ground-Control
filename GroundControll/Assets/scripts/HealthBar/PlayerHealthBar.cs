using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{

    public Slider HPSlider;
    public Gradient GradientSlider;
    public Image Fill;
    public void SetMaxHealth (int health)
    {
        HPSlider.maxValue = health;
        HPSlider.value = health;

        Fill.color = GradientSlider.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        HPSlider.value = health;

        Fill.color = GradientSlider.Evaluate(HPSlider.normalizedValue);
    }

}
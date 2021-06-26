using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MotherHealthBar : MonoBehaviour
{
    public Slider HPSlider;
    public Gradient GradientSlider;
    private float TargetHealthMothership;
    private float SlidingTime = 0.2f;
    public Image Fill;
    public void SetMaxHealth(float health)
    {
        HPSlider.maxValue = health;
        HPSlider.value = health;

        Fill.color = GradientSlider.Evaluate(1f);
    }

    public void SetHealth(float health)
    {
        TargetHealthMothership = health;
        HPSlider.DOValue(TargetHealthMothership, SlidingTime);

        Fill.color = GradientSlider.Evaluate(HPSlider.normalizedValue);
    }
}

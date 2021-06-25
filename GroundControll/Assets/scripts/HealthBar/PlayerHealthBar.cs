using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PlayerHealthBar : MonoBehaviour
{

    public Slider HPSlider;
    public Gradient GradientSlider;
    private float TargetHealthPlayer;
    private float SlidingTime = 0.2f;
    public Image Fill;
    public void SetMaxHealth (int health)
    {
        HPSlider.maxValue = health;
        HPSlider.value = health;

        Fill.color = GradientSlider.Evaluate(1f);
    }
    private void Update()
    {
        Fill.color = GradientSlider.Evaluate(HPSlider.normalizedValue);
    }

    public void SetHealth(int health)
    {
        TargetHealthPlayer = health;
        HPSlider.DOValue(TargetHealthPlayer, SlidingTime);

        Fill.color = GradientSlider.Evaluate(HPSlider.normalizedValue);
    }

}
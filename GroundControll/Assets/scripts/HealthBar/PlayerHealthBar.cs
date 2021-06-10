using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    public GameObject HealthOne;
    public GameObject HealthTwo;
    public GameObject HealthThree;
    public GameObject HealthFour;
    public GameObject HealthFive;
    public GameObject HealthSix;
    public Material ColorGreen;
    public Material ColorYellow;
    public Material ColorRed;
    public Material ColorChanging;

    void Update()
    {
        switch (PlayerHP.PlayerHealth)
        {
            default:
                break;
            case 120:
                ColorChanging.color = ColorGreen.color;
                break;
            case 100:
                HealthOne.SetActive(false);
                break;
            case 80:
                HealthTwo.SetActive(false);
                ColorChanging.color = ColorYellow.color;
                break;
            case 60:
                HealthThree.SetActive(false);
                break;
            case 40:
                HealthFour.SetActive(false);
                ColorChanging.color = ColorRed.color;
                break;
            case 20:
                HealthFive.SetActive(false);
                break;
        }

    }

    private void OnApplicationQuit()
    {
        ColorChanging.color = ColorGreen.color;
    }
}

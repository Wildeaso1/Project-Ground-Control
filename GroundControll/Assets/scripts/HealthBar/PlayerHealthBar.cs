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
    public Material HealthColor;
    public static int HPFull = PlayerHP.MaxHealth;
    public static double HP2 = PlayerHP.MaxHealth / 1.2;
    public static double HP3 = PlayerHP.MaxHealth / 1.5;
    public static int HP4 = PlayerHP.MaxHealth / 2;
    public static int HP5 = PlayerHP.MaxHealth / 3;
    public static int HP6 = PlayerHP.MaxHealth /6; 

    private void Start()
    {

    }

    void Update()
    {
        if (PlayerHP.PlayerHealth == HPFull)
        {
            HealthColor.color = Color.green;

        }
        if (PlayerHP.PlayerHealth == HP2)
        {
            HealthOne.SetActive(false);
        }
        if (PlayerHP.PlayerHealth == HP3)
        {
            HealthTwo.SetActive(false);
            HealthColor.color = Color.yellow;
        }
        if (PlayerHP.PlayerHealth == HP4)
        {
            HealthThree.SetActive(false);
        }
        if (PlayerHP.PlayerHealth == HP5)
        {
            HealthFour.SetActive(false);
            HealthColor.color = Color.red;
        }
        if (PlayerHP.PlayerHealth == HP6)
        {
            HealthFive.SetActive(false);
        }
    }

    private void OnApplicationQuit()
    {
    }
}



/*switch (PlayerHP.PlayerHealth)
    {
        default:
            break;
        case PlayerHP.MaxHealth:
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
    }*/
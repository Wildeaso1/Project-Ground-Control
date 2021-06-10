using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidHealthBar : MonoBehaviour
{
    public GameObject HUD;
    public GameObject A1;
    public GameObject A2;
    public GameObject A3;
    public static int Half = AsteroidHealth.AsteroidHPSmall / 2;
    public static int Low = AsteroidHealth.AsteroidHPSmall / 3;

    private void Start()
    {
        HUD.SetActive(false);
    }
    void Update()
    {
        if (AsteroidHealth.AsteroidHPSmall == AsteroidHealth.AsteroidHPSmallMax)
        {
            A1.SetActive(true);
            A2.SetActive(true);
        }
        if (AsteroidHealth.AsteroidHPSmall == Half)
        {
            HUD.SetActive(true);
            A1.SetActive(false);
        }
        if (AsteroidHealth.AsteroidHPSmall == Low)
        {
            A2.SetActive(false);
        }
    }
}

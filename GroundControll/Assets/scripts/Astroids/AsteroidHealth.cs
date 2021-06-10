using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidHealth : MonoBehaviour
{
    public static int AsteroidHPSmall;
    public static int AsteroidHPSmallMax;

    private void Start()
    {
        AsteroidHPSmall = AsteroidHPSmallMax;
    }

    public int AsteroidHealthPoints
    {
        get { return AsteroidHPSmall; }
        set { AsteroidHPSmall = Mathf.Clamp(AsteroidHPSmall, 0, 3); }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            AsteroidHPSmall -= 1;
        }
    }

}

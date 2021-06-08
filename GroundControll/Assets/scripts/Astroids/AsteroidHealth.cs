using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidHealth : MonoBehaviour
{
    public static int AsteroidHP;


    private void Start()
    {
        AsteroidHP = 4;
    }

    public int AsteroidHealthPoints
    {
        get { return AsteroidHP; }
        set { AsteroidHP = Mathf.Clamp(AsteroidHP, 0, 5); }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            AsteroidHP -= 1;
        }
    }

}

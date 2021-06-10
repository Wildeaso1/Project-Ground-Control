using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidHealth : MonoBehaviour
{
    public int AsteroidHPSmall;
    public int AsteroidHPSmallMax = 1;
    public AsteroidHealthBar asteroidHealthBar;

    private void Start()
    {
        AsteroidHPSmall = AsteroidHPSmallMax;
        asteroidHealthBar.SetMaxHealth(AsteroidHPSmallMax);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            TakeDamage(1);
        }
    }

    private void TakeDamage(int Damage)
    {

         AsteroidHPSmall -= Damage;
         asteroidHealthBar.SetHealth(AsteroidHPSmall);
    }

}

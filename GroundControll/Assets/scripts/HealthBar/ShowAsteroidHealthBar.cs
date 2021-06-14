using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAsteroidHealthBar : MonoBehaviour
{
    public GameObject Bar;

    private void Start()
    {
        Bar.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Spaceship")
        {
            Bar.SetActive(true);
        }
    }
}

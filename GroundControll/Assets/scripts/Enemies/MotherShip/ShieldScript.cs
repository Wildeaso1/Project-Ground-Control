using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScript : MonoBehaviour
{
    private bool shieldDown;
    private int maxHealth = 6;
    public int curHealth;

    Collider shieldCollider;

    private Color hitColor = Color.red;
    private Color baseColor = Color.blue;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = baseColor;
        shieldCollider = GetComponent<Collider>();
        curHealth = maxHealth;
        shieldDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (curHealth <= 0)
        {
            shieldDown = true;
            curHealth = 1;
            StartCoroutine(ShieldRecharge());
        }

        switch (shieldDown)
        {
            case true:
                gameObject.GetComponent<CircleCollider2D>().enabled = false;
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                break;
            case false:
                gameObject.GetComponent<CircleCollider2D>().enabled = true;
                gameObject.GetComponent<SpriteRenderer>().enabled = true;
                break;
        }
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            StartCoroutine(GetHit());
        }
    }

    IEnumerator GetHit()
    {
        gameObject.GetComponent<Renderer>().material.color = hitColor;
        yield return new WaitForSeconds(0.2f);
        gameObject.GetComponent<Renderer>().material.color = baseColor;
    }

    IEnumerator ShieldRecharge()
    {
        yield return new WaitForSeconds(6.0f);
        curHealth = maxHealth;
        shieldDown = false;
    }
}

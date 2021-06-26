using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScript : MonoBehaviour
{
    private bool shieldDown;
    private int maxHealth = 10;
    public int curHealth;

    Collider shieldCollider;
    // Start is called before the first frame update
    void Start()
    {
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

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            curHealth -= 1;
        }
    }

    IEnumerator ShieldRecharge()
    {
        yield return new WaitForSeconds(6.0f);
        curHealth = maxHealth;
        shieldDown = false;
    }
}

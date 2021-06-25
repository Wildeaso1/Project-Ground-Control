using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MothershipHealth : MonoBehaviour
{
    public float maxHealth = 1000;
    public float curHealth;
    public MotherHealthBar HealthBar;
    public GameObject asteroidObject;

    private AsteroidHealth damage;

    // Start is called before the first frame update
    void Start()
    {
        damage = asteroidObject.GetComponent<AsteroidHealth>();
        curHealth = maxHealth;
        HealthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (curHealth <= 0)
        {
            Destroy(this.gameObject);
            Debug.Log("Kapot");
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            curHealth -= damage.TakingDamage;
            HealthBar.SetHealth(curHealth);
        }
    }
}

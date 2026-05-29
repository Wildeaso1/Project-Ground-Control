using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MothershipHealth : MonoBehaviour
{
    public GameObject Shop;
    public GameObject explosion;
    public GameObject SpaceTiles;
    public GameObject BSMusic;
    public GameObject Ship;
    public GameObject EndingMusic;
    public GameObject Transiton;
    public float maxHealth = 1000;
    public float curHealth;
    public MotherHealthBar HealthBar;
    public GameObject asteroidObject;
    public Camera BossCam;
    public Camera BossCamAnim;
    public Canvas Health;
    public Canvas Points;
    public Canvas BsHealth;
    public Canvas Text;
    public Animator Anim;
    public GameObject EndingText;


    private AsteroidHealth damage;

    // Start is called before the first frame update
    void Start()
    {
        if (asteroidObject != null)
            damage = asteroidObject.GetComponent<AsteroidHealth>();
        else
            Debug.LogWarning("MothershipHealth: asteroidObject not assigned on " + gameObject.name);

        curHealth = maxHealth;

        if (HealthBar != null)
            HealthBar.SetMaxHealth(maxHealth);
        else
            Debug.LogWarning("MothershipHealth: HealthBar not assigned on " + gameObject.name);

        if (explosion != null)
            explosion.gameObject.SetActive(false);
        if (BossCamAnim != null)
            BossCamAnim.gameObject.SetActive(false);
        if (SpaceTiles != null)
            SpaceTiles.gameObject.SetActive(false);
        if (Ship != null)
            Ship.gameObject.SetActive(false);
        if (Transiton != null)
            Transiton.gameObject.SetActive(false);
        if (Text != null)
            Text.enabled = false;
        if (EndingText != null)
            Anim = EndingText.GetComponent<Animator>();
        else
            Debug.LogWarning("MothershipHealth: EndingText not assigned on " + gameObject.name);

        if (EndingMusic != null)
            EndingMusic.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (curHealth <= 0)
        {
            this.gameObject.SetActive(false);
            Debug.Log("Kapot");
            if (explosion != null) explosion.gameObject.SetActive(true);
            if (BossCam != null) BossCam.gameObject.SetActive(false);
            if (BossCamAnim != null) BossCamAnim.gameObject.SetActive(true);
            if (SpaceTiles != null) SpaceTiles.gameObject.SetActive(true);
            if (BSMusic != null) BSMusic.gameObject.SetActive(false);
            if (Ship != null) Ship.gameObject.SetActive(true);
            if (Shop != null) Shop.gameObject.SetActive(false);
            if (Transiton != null) Transiton.gameObject.SetActive(true);
            if (Health != null) Health.enabled = false;
            if (BsHealth != null) BsHealth.enabled = false;
            if (Points != null) Points.enabled = false;
            if (Text != null) Text.enabled = true;
            if (Anim != null) Anim.SetBool("Active", true);
            if (EndingMusic != null) EndingMusic.SetActive(true);
        }
        if (HealthBar != null) HealthBar.SetHealth(curHealth);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col != null && col.CompareTag("Bullet"))
        {
            if (damage != null)
                curHealth -= damage.TakingDamage;
            else
                Debug.LogWarning("MothershipHealth: damage (AsteroidHealth) reference is null.");

            if (HealthBar != null)
                HealthBar.SetHealth(curHealth);
        }
    }
}

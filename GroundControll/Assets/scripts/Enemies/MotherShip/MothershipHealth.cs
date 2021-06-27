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
        damage = asteroidObject.GetComponent<AsteroidHealth>();
        curHealth = maxHealth;
        HealthBar.SetMaxHealth(maxHealth);
        explosion.gameObject.SetActive(false);
        BossCamAnim.gameObject.SetActive(false);
        SpaceTiles.gameObject.SetActive(false);
        Ship.gameObject.SetActive(false);
        Transiton.gameObject.SetActive(false);
        Text.enabled = false;
        Anim = EndingText.GetComponent<Animator>();
        EndingMusic.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (curHealth <= 0)
        {
            this.gameObject.SetActive(false);
            Debug.Log("Kapot");
            explosion.gameObject.SetActive(true);
            BossCam.gameObject.SetActive(false);
            BossCamAnim.gameObject.SetActive(true);
            SpaceTiles.gameObject.SetActive(true);
            BSMusic.gameObject.SetActive(false);
            Ship.gameObject.SetActive(true);
            Shop.gameObject.SetActive(false);
            Transiton.gameObject.SetActive(true);
            Health.enabled = false;
            BsHealth.enabled = false;
            Points.enabled = false;
            Text.enabled = true;
            Anim.SetBool("Active", true);
            EndingMusic.SetActive(true);
        }
        HealthBar.SetHealth(curHealth);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public static int MaxHealth = 120;
    public static int PlayerHealth;
    public PlayerHealthBar HealthBar;
    public string GameOverScene;
    public GameObject LightUpUi;
    public static bool Started = false;


    private void Start()
    {
        PlayerHealth = MaxHealth;
        HealthBar.SetMaxHealth(MaxHealth);
    }

    private void Update()
    {
        if (PlayerHealth == 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(GameOverScene);
            PlayerHealth = MaxHealth;
        }

        
       if (PlayerHealth <= 40 && !Started)
        {
            StartCoroutine(LightUp());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            PlayerHealth -= 10;
            HealthBar.SetHealth(PlayerHealth);
        }
    }


    IEnumerator LightUp()
    {
        Started = true;
        LightUpUi.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        LightUpUi.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        Started = false;
    }
}

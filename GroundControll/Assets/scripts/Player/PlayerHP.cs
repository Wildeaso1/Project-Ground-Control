using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public static int PlayerHealth = 100;
    public Text HealthText;
    public string GameOverScene;
    private void Update()
    {
        if (PlayerHealth == 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(GameOverScene);
            PlayerHealth = 100;
        }

        HealthText.text = "" + PlayerHealth;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            PlayerHealth -= 10;
            Debug.Log("Hi");
        }
    }

    
}

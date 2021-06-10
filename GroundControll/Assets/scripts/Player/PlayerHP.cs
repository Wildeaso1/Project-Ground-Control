using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public static int PlayerHealth = 120;
    public string GameOverScene;
    public GameObject LightUpUi;
    public static bool Started = false;

    private void Start()
    {
    }

    private void Update()
    {
        if (PlayerHealth == 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(GameOverScene);
            PlayerHealth = 120;
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
        }
    }


    IEnumerator LightUp()
    {
        Started = true;
        Debug.Log("Testing");
        LightUpUi.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        LightUpUi.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        Started = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public string SceneTransition;

    public void ToMainMenu()
    {
        if (!string.IsNullOrEmpty(SceneTransition))
            SceneManager.LoadScene(SceneTransition);
        else
            Debug.LogError("Buttons: SceneTransition is empty or not set on " + gameObject.name);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}

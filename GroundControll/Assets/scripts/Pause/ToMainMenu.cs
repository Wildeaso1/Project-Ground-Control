using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ToMainMenu : MonoBehaviour
{

    public string mainMenu;

    public void ToMenu()
    {
        if (!string.IsNullOrEmpty(mainMenu))
            SceneManager.LoadScene(mainMenu);
        else
            Debug.LogError("ToMainMenu: mainMenu string is empty or not set on " + gameObject.name);
    }

    void UnpauseGame()
    {
        Time.timeScale = 1;
    }
}

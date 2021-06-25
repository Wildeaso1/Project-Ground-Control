using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ToMainMenu : MonoBehaviour
{

    public string mainMenu;

    public void ToMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }

    void UnpauseGame()
    {
        Time.timeScale = 1;
    }
}

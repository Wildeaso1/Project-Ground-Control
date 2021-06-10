using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public string Scene;

    public void Play() // Play Button Script
    {

        SceneManager.LoadScene(Scene); // Opent level 0 "Scene index 1"

    }

    public void Exit() // Quit Button Function
    {
        Application.Quit();

        // Debug For in Editor Testing
        Debug.Log("Quit");
    }
}

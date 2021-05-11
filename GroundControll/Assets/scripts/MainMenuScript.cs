using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Play() // Play Button Script
    {

        SceneManager.LoadScene("Level_0"); // Opent level 0 "Scene index 1"

    }

    public void Exit() // Quit Button Function
    {
        Application.Quit();

        // Debug For in Editor Testing
        Debug.Log("Quit");
    }
}

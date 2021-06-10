using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrans : MonoBehaviour
{
    
    public string sceneToGo;

    public void ToMenu()
    {
        SceneManager.LoadScene(sceneToGo);
    }

    public void Quit()
    {
        Application.Quit();
    }
}

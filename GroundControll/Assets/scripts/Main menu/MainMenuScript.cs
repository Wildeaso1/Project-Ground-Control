using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{

    public string Scene;
    public GameObject LoadingScreen;
    private GameObject EndMusic;
    public Slider Pslider;

    private void Start()
    {

        EndMusic = GameObject.FindGameObjectWithTag("EndMusic");

        if (EndMusic)
        {
            Destroy(EndMusic);
        }    
    }


    public void NewGame() // Play Button Script
    {
        
        LoadLevel(3); // Opent level 0 "Scene index 1"
        SaveManager.DeleteSave();
        PlayerPrefs.SetInt("BoosterLevel", 1);
        PlayerPrefs.SetInt("GunLevel", 1);
        PlayerPrefs.SetInt("RotationLevel", 1);
    }

    public void LoadGame()
    {

        LoadLevel(1);

    }


    public void Exit() // Quit Button Function
    {
        Application.Quit();

        // Debug For in Editor Testing
        Debug.Log("Quit");
    }

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsyncLevel(sceneIndex));
    }


    IEnumerator LoadAsyncLevel(int sceneIndex)
    {
        LoadingScreen.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            Pslider.value = progress;

            yield return null;
        }
    }

}

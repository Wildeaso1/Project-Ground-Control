using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToEnd : MonoBehaviour
{


    public string Space;
    public GameObject LoadingScreen;
    public Slider Pslider;
    public GameObject BackgroundMusic;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        LoadLevel(5);
    }


    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsyncLevel(sceneIndex));
    }


    IEnumerator LoadAsyncLevel(int sceneIndex)
    {
        LoadingScreen.SetActive(true);
        BackgroundMusic.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            Pslider.value = progress;

            yield return null;
        }
    }
}


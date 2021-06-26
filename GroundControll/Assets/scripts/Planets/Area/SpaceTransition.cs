using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpaceTransition : MonoBehaviour
{

    private bool range;
    public string Scene;
    public GameObject pressE;
    public GameObject LoadingScreen;
    public Slider Pslider;

    

    // Start is called before the first frame update
    void Start()
    {
        LoadingScreen.SetActive(false);
        pressE.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (range && Input.GetKeyDown(KeyCode.E))
        {
            Inventory.ScoreCredits = PlayerPrefs.GetInt("Credits");
            LoadLevel(1);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        range = true;
        pressE.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        range = false;
        pressE.SetActive(false);
    }

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsyncLevel(sceneIndex));
    }


    IEnumerator LoadAsyncLevel (int sceneIndex)
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

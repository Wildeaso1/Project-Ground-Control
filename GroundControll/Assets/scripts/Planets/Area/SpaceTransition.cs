using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceTransition : MonoBehaviour
{

    private bool range;
    public string Scene;
    public GameObject pressE;

    

    // Start is called before the first frame update
    void Start()
    {
        pressE.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (range && Input.GetKeyDown(KeyCode.E))
        {
            Inventory.ScoreCredits = PlayerPrefs.GetInt("Credits");
            SceneManager.LoadScene(Scene);
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
}

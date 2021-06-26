using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToPlanet : MonoBehaviour
{

    private bool range;
    public string Scene;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (range && Input.GetKeyDown(KeyCode.E))
        {
            PlayerPrefs.SetInt("Credits", Inventory.ScoreCredits);
            SceneManager.LoadScene(Scene);
        }
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        range = true;
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        range = false;
    }
}
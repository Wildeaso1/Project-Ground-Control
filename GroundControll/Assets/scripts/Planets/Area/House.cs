using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class House : MonoBehaviour
{

    private bool range;
    public GameObject textBox;

    public Canvas ShopCanvas;
    // Start is called before the first frame update
    void Start()
    {
        textBox.SetActive(false);
     
    }

    // Update is called once per frame
    void Update()
    {
        if (range && Input.GetKeyDown(KeyCode.E))
        {
            ShopCanvas.enabled = true;
            range = false;
        }

        else if (ShopCanvas.enabled == true && Input.GetKeyDown(KeyCode.E))
        {
            ShopCanvas.enabled = false;
            range = true;
        }
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        range = true;
        textBox.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        range = false;
        ShopCanvas.enabled = false;
        textBox.SetActive(false);
    }
}



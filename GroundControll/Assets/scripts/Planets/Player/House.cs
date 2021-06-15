using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class House : MonoBehaviour
{

    private bool Range;

    public Canvas ShopCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Range && Input.GetKeyDown(KeyCode.E))
        {
            ShopCanvas.enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Range = true;
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        Range = false;
        ShopCanvas.enabled = false;
    }
}



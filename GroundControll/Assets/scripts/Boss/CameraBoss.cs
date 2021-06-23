using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraBoss : MonoBehaviour
{

    public Camera cameraBoss;
    public Camera cameraMain;

    private void Start()
    {
        cameraMain.enabled = true;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Spaceship")
        {
            cameraMain.enabled = false;
            cameraBoss.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Spaceship")
        {
            cameraMain.enabled = true;
            cameraBoss.enabled = false;
        }
    }
}

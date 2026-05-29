using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraBoss : MonoBehaviour
{

    public Camera cameraBoss;
    public Camera cameraMain;

    public MotherScript motherScript;
    public GameObject healthSlider;

    private void Start()
    {
        if (cameraMain != null)
            cameraMain.enabled = true;
        else
            Debug.LogWarning("CameraBoss: cameraMain not assigned on " + gameObject.name);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null && collision.CompareTag("Asteroid"))
        {
            Destroy(collision.gameObject);
        }

        if (collision != null && collision.CompareTag("Spaceship"))
        {
            MotherScript.inZone = true;

            if (cameraMain == null || cameraBoss == null)
            {
                Debug.LogWarning("CameraBoss: cameraMain or cameraBoss not assigned on " + gameObject.name);
            }
            else
            {
                // Preserve orthographic size to avoid sudden zoom changes
                if (cameraMain.orthographic && cameraBoss.orthographic)
                    cameraBoss.orthographicSize = cameraMain.orthographicSize;

                // Use GameObject active state to switch cameras safely
                cameraMain.gameObject.SetActive(false);
                cameraBoss.gameObject.SetActive(true);
            }

            if (healthSlider != null)
                healthSlider.SetActive(true);
            else
                Debug.LogWarning("CameraBoss: healthSlider not assigned on " + gameObject.name);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision != null && collision.CompareTag("Spaceship"))
        {
            MotherScript.inZone = false;

            if (cameraMain == null || cameraBoss == null)
            {
                Debug.LogWarning("CameraBoss: cameraMain or cameraBoss not assigned on " + gameObject.name);
            }
            else
            {
                cameraMain.gameObject.SetActive(true);
                cameraBoss.gameObject.SetActive(false);
            }

            if (healthSlider != null)
                healthSlider.SetActive(false);
            else
                Debug.LogWarning("CameraBoss: healthSlider not assigned on " + gameObject.name);
        }
    }
}

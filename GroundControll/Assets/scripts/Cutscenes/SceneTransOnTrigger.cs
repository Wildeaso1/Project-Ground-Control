using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransOnTrigger : MonoBehaviour
{

    public string Space;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(Space);
    }
}

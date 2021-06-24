using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Walls")
        {
            Destroy(this.gameObject);
            Debug.Log("Cum");
        }
    }
}

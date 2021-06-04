using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float Speed = 100;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddRelativeForce(Vector2.up * Speed);
        Destroy(this.gameObject, 2.5f);
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "Debris")
        {
            Destroy(this.gameObject);
        }
    }
}

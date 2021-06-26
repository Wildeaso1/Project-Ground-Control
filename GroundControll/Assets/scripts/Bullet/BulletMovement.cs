using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float Speed = 100;
    public Rigidbody2D rb;
    // Gives speed to the bullet.
    void Start()
    {
        rb.AddRelativeForce(Vector2.up * Speed);
        Destroy(this.gameObject, 2.5f);
    }
    // bullet destroys astroid
    void OnTriggerEnter2D (Collider2D col)
    {
        switch (col.gameObject.tag)
        {
            case "Asteroid":
                Destroy(this.gameObject);
                break;
            case "Enemy":
                Destroy(col.gameObject);
                Destroy(this.gameObject);
                break;
            case "Shield":
                Destroy(this.gameObject);
                break;
            case "Mothership":
                Destroy(this.gameObject);
                break;
            default:
                break;
        }
    }
}

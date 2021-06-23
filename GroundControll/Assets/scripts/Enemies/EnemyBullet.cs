using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddRelativeForce(Vector2.up * speed);
        Destroy(this.gameObject, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D (Collider2D col)
    {
        switch (col.gameObject.tag)
        {
            case "Asteroid":
                Destroy(this.gameObject);
                break;
            case "Spacship":
                Destroy(this.gameObject);
                break;
            default:
                break;
        }
    }
}

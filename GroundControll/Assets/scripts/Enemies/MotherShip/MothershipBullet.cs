using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MothershipBullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddRelativeForce(Vector2.up * speed);
        Destroy(this.gameObject, 6f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Spaceship")
        {
            Destroy(this.gameObject);
        }
    }
}

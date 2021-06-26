using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDroidScript : MonoBehaviour
{
    public float speed;

    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Ship").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.right = target.position - transform.position;
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        switch (col.gameObject.tag)
        {
            case "Spaceship":
                Destroy(this.gameObject);
                break;
            case "Asteroid":
                Destroy(this.gameObject);
                break;
            default:
                break;
        }
    }
}

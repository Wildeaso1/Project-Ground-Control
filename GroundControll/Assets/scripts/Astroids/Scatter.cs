using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scatter : MonoBehaviour
{
    public  GameObject IronObject;
    public  GameObject GoldObject;
    public  GameObject CobaltObject;
    public Transform SpawnPoint;
    private Rigidbody2D _rigidbody;
    //private float speed = 10.0f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Random Rotation en Speed voor astroids
    void Start()
    {
        transform.rotation = (Quaternion.Euler(0, 0, Random.Range(0, 360)));
        _rigidbody.AddForce(transform.up * Random.Range(20.0f, 25.0f));
    }
    // Scattering van de iron gold en Cobalt

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var IronN = Random.Range(1, 5);
        var GoldN = Random.Range(-1, 2);
        var CobaltN = Random.Range(0, 3);

        if (collision.gameObject.tag == "Bullet")
        {
            for (int i = 0; i < IronN; i++) 
            {
                GameObject Iron = Instantiate(IronObject, SpawnPoint.position, Quaternion.Euler(0, 0, Random.Range(0,360)));
                GetComponent<Sound>().PlayEffect();
                Destroy(this.gameObject);
                Iron.GetComponent<ScatterMovement>().speed = Random.Range(10.0f, 20.0f);
            }
            for (int i = 0; i < GoldN; i++)
            {
                GameObject Gold = Instantiate(GoldObject, SpawnPoint.position, Quaternion.Euler(0, 0, Random.Range(0, 360)));
                Gold.GetComponent<ScatterMovement>().speed = Random.Range(10.0f, 20.0f);
            }
            for (int i = 0; i < CobaltN; i++)
            {
                GameObject Cobalt = Instantiate(CobaltObject, SpawnPoint.position, Quaternion.Euler(0, 0, Random.Range(0, 360)));
                Cobalt.GetComponent<ScatterMovement>().speed = Random.Range(10.0f, 20.0f);
            }

        }

        if (collision.gameObject.tag == "Walls")
        {
            Destroy(this.gameObject);
        }
    }



    // Zorgt ervoor dat elke astroid scatter een andere rotation heeft
    void Update()
    {
        int rotation = Random.Range(0, 360);
    }
}

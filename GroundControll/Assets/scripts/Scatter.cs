using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scatter : MonoBehaviour
{
    public GameObject Debris;
    public Transform SpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var number = Random.Range(1, 10);
        for (int i = 0; i < number; i++) 
        {
            GameObject pieces = Instantiate(Debris, SpawnPoint.position, Quaternion.Euler(0, 0, Random.Range(0,360)));
            Destroy(this.gameObject);
            pieces.GetComponent<ScatterMovement>().speed = Random.Range(10.0f, 20.0f);
            GetComponent<Sound>().Playsound.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        int rotation = Random.Range(0, 360);
    }
}

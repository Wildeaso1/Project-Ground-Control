using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scatter : MonoBehaviour
{
    public  GameObject IronObject;
    public  GameObject GoldObject;
    public  GameObject CobaltObject;
    public Transform SpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var IronN = Random.Range(2, 4);
        var GoldN = Random.Range(-1, 2);
        var CobaltN = Random.Range(1, 4);
        for (int i = 0; i < IronN; i++) 
        {
            GameObject Iron = Instantiate(IronObject, SpawnPoint.position, Quaternion.Euler(0, 0, Random.Range(0,360)));
            Destroy(this.gameObject);
            Iron.GetComponent<ScatterMovement>().speed = Random.Range(10.0f, 20.0f);
            GetComponent<Sound>().Playsound.Play();
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



    // Update is called once per frame
    void Update()
    {
        int rotation = Random.Range(0, 360);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public int Amount;
    public Transform ship;
    public float minR = 6;
    public float maxR = 30;

    void Start()
    {
        InvokeRepeating("spawnObjects", 30f, 30f);
        spawnObjects();
    }

    private void Update()
    {
        GameObject[] asteroids = GameObject.FindGameObjectsWithTag("Asteroid");
        if (asteroids.Length < Amount)
        {
            spawnObjects();
        }
    }


    public void spawnObjects()
    {
        int randomItem = 0;
        GameObject toSpawn;

        for(int i = 0; i< numberToSpawn; i++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            Vector2 center = ship.transform.position;

            float finalRadius = Random.Range(minR, maxR);

            float angle = Random.Range(0, 360) * Mathf.Deg2Rad;

            Vector2 spawnPos = center + new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)) * finalRadius;

            Instantiate(toSpawn, spawnPos, toSpawn.transform.rotation);
        }
    }





    private void OnDrawGizmos()
    {
        if (ship != null)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawWireSphere(ship.position, minR);
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(ship.position, maxR);
            Gizmos.color = Color.white;
        }
    }






    private void destroyObjects()
    {
        foreach(GameObject o in GameObject.FindGameObjectsWithTag("Spawnable"))
        {
            Destroy(o);
        }
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlackhole : MonoBehaviour
{


    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public GameObject quad;
    public int Amount;
    [SerializeField] private float RealDistance;
    public Transform target;
    public Vector3 vec3;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObjects", 2f, 2f);
        spawnObjects();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] BlachHole = GameObject.FindGameObjectsWithTag("Blackhole");
        if (BlachHole.Length < Amount)
        {
            spawnObjects();
        }
    }

    public void spawnObjects()
    {
        int randomItem = 0;
        
        GameObject toSpawn;
        MeshCollider c = quad.GetComponent<MeshCollider>();

        float screenX; 
        float screenY;
        Vector2 pos;

        var direction = target.position - transform.position;
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;

        if (direction.magnitude < RealDistance)
        {
            for (int i = 0; i < numberToSpawn; i++)
            {
                randomItem = Random.Range(0, spawnPool.Count);
                toSpawn = spawnPool[randomItem];

                screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
                screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
                pos = new Vector2(screenX, screenY);

                Instantiate(toSpawn, pos, toSpawn.transform.rotation);

            }
            
        }
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    public int attackRange;
    public Transform enemyBulletSpawn;
    public GameObject enemyBulletPrefab;
    public float fireRate;

    private Transform target;
    private float nextShot;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Ship").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.right = target.position - transform.position;
        Shooting();
    }

    void Shooting()
    {
        if (Vector2.Distance(gameObject.transform.position, target.transform.position) < attackRange)
        {
            if (nextShot <= 0)
            {
                nextShot = fireRate;
                Instantiate(enemyBulletPrefab, enemyBulletSpawn.position, enemyBulletSpawn.rotation);
            }
            else
            {
                nextShot -= Time.deltaTime;
            }
        }
        else
        {
            nextShot = 0;
        }
    }
}
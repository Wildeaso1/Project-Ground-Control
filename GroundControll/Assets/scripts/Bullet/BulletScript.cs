using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Transform bulletSpawn;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }


// Update is called once per frame
void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Shoot();
            GetComponent<SpaceShipScript>().ShootingEffect();
        }
    }

    // Shooting the bullet
    void Shoot()
    {
        Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
    }
}

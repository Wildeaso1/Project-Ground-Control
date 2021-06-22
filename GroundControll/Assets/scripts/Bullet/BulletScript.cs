using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Transform bulletSpawn;
    public GameObject bulletPrefab;


// Key press to shoot
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

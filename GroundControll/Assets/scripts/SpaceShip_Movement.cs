using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip_Movement : MonoBehaviour
{

    float maxSpeed = 5f;
    float rotSpeed = -180f;

    void Start()
    {
        
    }

    void Update()
    {

        // spaceship rotation
        /* Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rot = Quaternion.Euler( 0, 0, z ); */
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, rotSpeed * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, -rotSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.right * Time.deltaTime * maxSpeed;
        }

        //Move Spaceship

        /*Vector3 pos = transform.position;

        pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;

        transform.position = pos;*/


    }
}

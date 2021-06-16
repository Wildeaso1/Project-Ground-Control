using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipScript : MonoBehaviour
{
    public static float thrustSpeed = 10.0f; 
    public static int rotationSpeed =  2; 
    private Rigidbody2D _rigidbody;
    private bool _thrusting;
    private bool _thrustingBack;
    private float _turnDirection;
    public AudioSource Shooting;
    public static int cannonLevel = 1;
    public static int boosterLevel = 1;
    public static int rotationLevel = 1;

    // Start is called before the first frame update
    public void ShootingEffect()
    {
        Shooting.Play();
    }
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _turnDirection = 1.0f;
        }

        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _turnDirection = -1.0f;
        }

        else
        {
            _turnDirection = 0.0f;
        }


        if (boosterLevel == 1)
        {
            thrustSpeed = 10.0f;
        }

        if (boosterLevel == 2)
        {
            thrustSpeed = 20.0f;
        }

        if (boosterLevel == 3)
        {
            thrustSpeed = 30.0f;
        }

        if (rotationLevel == 1)
        {
            //rotationSpeed = 2.0f;
        }

        if (rotationLevel == 2)
        {
            //rotationSpeed = 100.0f;
        }

        if (rotationLevel == 3)
        {
            //rotationSpeed = 6.0f;
        }

        if (cannonLevel == 1)
        {
            rotationSpeed = 2;
        }

        if (cannonLevel == 2)
        {
            //placeholder for cannon = 4.0f;
        }

        if (cannonLevel == 3)
        {
            // placeholder for cannon ;
        }
    }

    private void FixedUpdate()
    {
        // Movement Up, Down and Rotation
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _rigidbody.AddForce(transform.up * thrustSpeed);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _rigidbody.AddForce(-transform.up * (thrustSpeed / 3));
        }

        if (_turnDirection != 0.0f)
        {
            _rigidbody.AddTorque(rotationSpeed * _turnDirection);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Cobalt":
                Inventory.ScoreCobalt += 1;
                Destroy(collision.gameObject);
                break;
            case "Iron":
                Inventory.ScoreIron += 1;
                Destroy(collision.gameObject);
                break;
            case "Gold":
                Inventory.ScoreGold += 1;
                Destroy(collision.gameObject);
                break;
            default:
                break;
        }
    }
}

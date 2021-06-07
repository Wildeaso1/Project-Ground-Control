using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipScript : MonoBehaviour
{
    // Variablen voor het ship
    public float thrustSpeed = 15.0f;
    public float thrustSpeedBackwards = -0.5f;
    public float rotationSpeed = 3.0f;
    private Rigidbody2D _rigidbody;
    private bool _thrusting;
    private bool _thrustingBack;
    private float _turnDirection;
    public AudioSource Shooting;

    // Shooting sound effect
    public void ShootingEffect()
    {
        Shooting.Play();
    }


    // Rigidbody
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Sideways Movement
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


        if (PlayerHP.PlayerHealth == 0)
        {
            Destroy(this.gameObject);
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
          _rigidbody.AddForce(transform.up /thrustSpeedBackwards);
        }

        if (_turnDirection != 0.0f)
        {
            _rigidbody.AddTorque(rotationSpeed * _turnDirection);
        }
    }

    // Score updaten met de juiste ores die je oppakt
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

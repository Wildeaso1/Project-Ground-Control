using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipScript : MonoBehaviour
{
    public float thrustSpeed = 15.0f;
    public float rotationSpeed = 3.0f;

    private Rigidbody2D _rigidbody;
    private bool _thrusting;
    private bool _thrustingBack;
    private float _turnDirection;

    // Start is called before the first frame update
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
}

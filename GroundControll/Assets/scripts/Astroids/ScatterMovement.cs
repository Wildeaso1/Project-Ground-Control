using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScatterMovement : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody2D _rigidbody;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        _rigidbody.AddForce(transform.up * speed);
    }
}

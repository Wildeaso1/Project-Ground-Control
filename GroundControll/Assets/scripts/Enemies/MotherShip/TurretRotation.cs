using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRotation : MonoBehaviour
{
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Ship").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.right = target.position - transform.position;
    }
}

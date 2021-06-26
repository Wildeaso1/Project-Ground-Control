using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDestroy : MonoBehaviour
{
    void FixedUpdate()
    {
        Destroy(gameObject, 5f); 
    }
}

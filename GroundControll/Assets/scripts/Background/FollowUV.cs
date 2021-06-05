using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowUV : MonoBehaviour
{

    float parallex = 3f;
    float parallex2 = 1f;

    void Update()
    {

        MeshRenderer mr = GetComponent<MeshRenderer>();

        Material mat = mr.material;

        Vector2 offset = mat.mainTextureOffset;

        offset.x = transform.position.x / transform.localScale.x / parallex2;
        offset.y = transform.position.y / transform.localScale.y / parallex;

        mat.mainTextureOffset = offset;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Target;

    public float SmoothSpeed = 0.125f;
    public Vector3 Offset;

     // Update is called once per frame
    void LateUpdate()
    {
        Vector3 DesiredPosition = Target.position + Offset;
        Vector3 SmoothedPosition = Vector3.Lerp(transform.position, DesiredPosition, SmoothSpeed);
        transform.position = SmoothedPosition;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public Image waypoint1;
    //public Image Waypoint2;
    public Transform Target1;
    //public Transform Target2;
    private float HideDistance = 30f;
    public Camera MainCamera;

    private void Start()
    {
        MainCamera = GameObject.FindGameObjectWithTag("Camera").GetComponent<Camera>();
    }

    void Update()
    {
        TargetLock1();
        //TargetLock2();

    }

    public void TargetLock1()
    {
        float minX = waypoint1.GetPixelAdjustedRect().width / 2;
        float maxX = Screen.width - minX;

        float minY = waypoint1.GetPixelAdjustedRect().height / 2;
        float maxY = Screen.height - minY;
        Vector2 pos = MainCamera.WorldToScreenPoint(Target1.position);

        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        waypoint1.transform.position = pos;
    }
   /* public void TargetLock2()
    {
        float minX = Waypoint2.GetPixelAdjustedRect().width / 2;
        float maxX = Screen.width - minX;

        float minY = Waypoint2.GetPixelAdjustedRect().height / 2;
        float maxY = Screen.height - minY;
        Vector2 pos = MainCamera.WorldToScreenPoint(Target2.position);

        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        Waypoint2.transform.position = pos;
    }*/
}

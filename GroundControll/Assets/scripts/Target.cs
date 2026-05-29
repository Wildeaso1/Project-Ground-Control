using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public Image waypoint1;
    public Image Waypoint2;
    public Transform Target1;
    public Transform Target2;
    private float HideDistance = 30f;
    public Camera MainCamera;

    private void Start()
    {
        // Prefer an explicit assignment in the inspector; fall back to Camera.main then to a GameObject tagged "Camera"
        if (MainCamera == null)
        {
            MainCamera = Camera.main;
            if (MainCamera == null)
            {
                GameObject camGo = null;
                try { camGo = GameObject.FindGameObjectWithTag("Camera"); } catch { camGo = null; }
                if (camGo != null)
                {
                    MainCamera = camGo.GetComponent<Camera>();
                }
            }

            if (MainCamera == null)
                Debug.LogWarning("Target: MainCamera not found. Waypoints will be disabled on " + gameObject.name);
        }
    }

    void Update()
    {
        TargetLock1();
        TargetLock2();

    }

    public void TargetLock1()
    {
        if (waypoint1 == null || Target1 == null || MainCamera == null) return;

        float minX = waypoint1.GetPixelAdjustedRect().width / 2;
        float maxX = Screen.width - minX;

        float minY = waypoint1.GetPixelAdjustedRect().height / 2;
        float maxY = Screen.height - minY;
        Vector2 pos = MainCamera.WorldToScreenPoint(Target1.position);

        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        waypoint1.transform.position = pos;
    }
   public void TargetLock2()
    {
        if (Waypoint2 == null || Target2 == null || MainCamera == null) return;

        float minX = Waypoint2.GetPixelAdjustedRect().width / 2;
        float maxX = Screen.width - minX;

        float minY = Waypoint2.GetPixelAdjustedRect().height / 2;
        float maxY = Screen.height - minY;
        Vector2 pos = MainCamera.WorldToScreenPoint(Target2.position);

        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        Waypoint2.transform.position = pos;
    }
}

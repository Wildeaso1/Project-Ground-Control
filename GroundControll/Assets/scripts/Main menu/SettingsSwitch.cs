using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsSwitch : MonoBehaviour
{

    public Canvas Menu;
    public Canvas Settings;

    void Start()
    {
        Settings.enabled = false;
        Menu.enabled = true;
    }

    public void Switch()
    {
        Menu.enabled = false;
        Settings.enabled = true;
    }

    public void SwitchBack()
    {
        Menu.enabled = true;
        Settings.enabled = false;
    }
}

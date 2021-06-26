using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsSwitch2 : MonoBehaviour
{
    public Canvas MainButtons;
    public Canvas Settings;

    private void Start()
    {
        Settings.enabled = false;
    }

    public void ToSettings()
    {
        MainButtons.enabled = false;
        Settings.enabled = true;
    }

    public void ToMainButtons()
    {
        MainButtons.enabled = true;
        Settings.enabled = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{

    public static void Save()
    {
        PlayerPrefs.Save();
    }

    public static void DeleteSave()
    {
        PlayerPrefs.DeleteAll();
    }
}

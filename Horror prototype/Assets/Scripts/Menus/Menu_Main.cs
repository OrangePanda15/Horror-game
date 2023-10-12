using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Main : MonoBehaviour
{
    [Header("Component References")]
    public GameObject settingsMenu;

    public void OpenSettingsMenu()
    {
        settingsMenu.SetActive(true);
    }
}

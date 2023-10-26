using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Main : MonoBehaviour
{
    [Header("Component References")]
    [SerializeField] private GameObject settingsMenu;

    public void OpenSettingsMenu()
    {
        settingsMenu.SetActive(true);
    }
}

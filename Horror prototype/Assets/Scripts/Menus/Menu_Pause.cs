using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Pause : MonoBehaviour
{
    [Header("Component References")]
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject settingsMenu;

    private void Start()
    {
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input_Manager.Pause())
        {
            if (!pauseMenu.activeSelf && !Game_Manager.UIInUse())
            {
                OpenPauseMenu();
            }
            else
            {
                ClosePauseMenu();
            }
        }
    }

    public void OpenPauseMenu()
    {
        pauseMenu.SetActive(true);
        Game_Manager.UpdateGameMode(Game_Manager.GameMode.ui);
        Game_Manager.SetUIUsage(true);
    }

    public void ClosePauseMenu()
    {
        pauseMenu.SetActive(false);
        Game_Manager.UpdateGameMode(Game_Manager.GameMode.normal);
        Game_Manager.SetUIUsage(false);
    }

    public void OpenSettingsMenu()
    {
        Logger.Log(this, "Opened settings in pause menu");
        settingsMenu.SetActive(true);
    }

    public void Quit()
    {
        Logger.Log(this, "Quit game");
        Application.Quit();
    }
}

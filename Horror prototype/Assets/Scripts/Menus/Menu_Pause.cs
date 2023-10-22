using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Pause : MonoBehaviour
{
    [Header("Component References")]
    public GameObject pauseMenu;
    public GameObject settingsMenu;

    private void Start()
    {
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input_Manager.Pause())
        {
            if (!pauseMenu.activeSelf)
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
    }

    public void ClosePauseMenu()
    {
        pauseMenu.SetActive(false);
        Game_Manager.UpdateGameMode(Game_Manager.GameMode.normal);
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

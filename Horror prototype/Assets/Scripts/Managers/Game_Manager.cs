using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Game_Manager
{
    // Exposed variables
    public static GameMode gameMode = GameMode.normal;
    public static Scene_Manager sceneManager = default(Scene_Manager);

    public enum GameMode
    {
        normal,
        ui
    }

    public enum AudioKeys
    {
        Audio_Music,
        Audio_UI,
        Audio_SFX
    }

    public static void UpdateGameMode(GameMode mode)
    {
        switch (mode)
        {
            case GameMode.normal:
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                break;

            case GameMode.ui:
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                break;
        }
    }
}

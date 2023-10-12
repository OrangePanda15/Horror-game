using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Game_Manager
{
    // Exposed variables
    public static GameMode gameMode = GameMode.normal;

    public enum GameMode
    {
        normal,
        ui
    }
}

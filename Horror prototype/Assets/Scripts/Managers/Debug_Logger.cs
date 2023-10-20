using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Logger
{
    //public static List<AnimationCurve> plots = new List<AnimationCurve>();

    static Dictionary<string, bool> logSources = new Dictionary<string, bool>
        {
            { "Interactable_Note", true },
            { "Interactable_Toggleable", true },
            { "Scene_Manager", true },
            { "Player_Interact", true },
            { "Input_Manager", true },
            { "Precise_Slider", false },
            { "Menu_Pause", false },
            { "Player_Camera", false },
            { "Game_Manager", false },
        };

    public static void Log<T>(T source, string str)
    {
        if (logSources[source.GetType().Name.ToString()])
            Debug.Log(source.GetType().Name.ToString() + ": " + str);
    }

    //public static void LogGraph<T>(T sourceType, string sourceName, float f)
    //{
    //    if ()
    //}
}

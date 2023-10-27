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
            { "Menu_Pause", true },
            { "Player_Camera", false },
            { "Game_Manager", false },
        };

    public enum logType
    {
        normal,
        warning,
        error
    }

    public static void Log<T>(T source, string str)
    {
        Log(source.GetType().Name.ToString(), str, logType.normal);
    }

    public static void Log<T>(T source, string str, logType type)
    {
        Log(source.GetType().Name.ToString(), str, type);
    }

    public static void Log(string source, string str, logType type)
    {
        if (logSources[source])
        {
            if (type == logType.error)
                Debug.LogError(source.ToString() + ": " + str);
            else if (type == logType.warning)
                Debug.LogWarning(source.ToString() + ": " + str);
            else if (type == logType.normal)
                Debug.Log(source.ToString() + ": " + str);
        }
    }

    //public static void LogGraph<T>(T sourceType, string sourceName, float f)
    //{
    //    if ()
    //}
}

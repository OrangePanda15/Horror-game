using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Logger
{
    public static Dictionary<string, bool> logSources = new Dictionary<string, bool>
        {
            { "Interactable_Note", true },
            { "Interactable_Toggleable", true },
            { "Scene_Manager", true }
        };

    public static void Log<T>(T source, string str)
    {
        if (logSources[source.GetType().Name.ToString()])
            Debug.Log(source.GetType().Name.ToString() + ": " + str);
    }
}

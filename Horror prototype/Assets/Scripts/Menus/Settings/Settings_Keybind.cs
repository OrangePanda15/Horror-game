using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings_Keybind : MonoBehaviour
{
    [Header("Exposed Variables")]
    public Input_Manager.keys key;

    [Header("Component References")]
    public Text buttonText;

    private void OnEnable()
    {
        buttonText.text = ((KeyCode)PlayerPrefs.GetInt(key.ToString())).ToString();
    }
}

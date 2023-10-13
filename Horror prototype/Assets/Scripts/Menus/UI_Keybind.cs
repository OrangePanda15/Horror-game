using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Keybind : MonoBehaviour
{
    [Header("Exposed Variables")]
    public string key;

    [Header("Component References")]
    public Text buttonText;

    private void OnEnable()
    {
        buttonText.text = ((KeyCode)PlayerPrefs.GetInt(key)).ToString();
    }
}

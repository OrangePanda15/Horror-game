using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings_Mouse : MonoBehaviour
{
    [Header("Exposed Variables")]
    public Input_Manager.keys key;

    [Header("Component References")]
    public Slider slider;
    public InputField field;

    public void OnEnable()
    {
        float sensitivity = PlayerPrefs.GetFloat(key.ToString());
        slider.value = sensitivity;
        field.text = sensitivity.ToString();
    }
}

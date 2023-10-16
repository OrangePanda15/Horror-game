using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Precise_Slider : MonoBehaviour
{
    [Header("Exposed Variables")]
    public string key;
    public string text;
    public float minValue;
    public float maxValue;
    public PreciseSliderType sliderType;

    [Header("Component References")]
    public Slider slider;
    public InputField field;
    public Text textUI;

    // Internal Variables
    float currentValue = -1.0f;

    public enum PreciseSliderType
    {
        normal,
        audio
    }

    private void OnEnable()
    {
        slider.minValue = minValue;
        slider.maxValue = maxValue;
        
        currentValue = Mathf.Clamp(PlayerPrefs.GetFloat(key), minValue, maxValue);
        Logger.Log(this, "Initialised currentValue to: " + currentValue.ToString());

        slider.value = currentValue;
        field.text = currentValue.ToString();

        textUI.text = text;

        Logger.Log(this, "Initialised slider to: (" + slider.value.ToString() + ", " + slider.minValue.ToString() + ", " + slider.maxValue.ToString() + ")");
    }

    public void UpdateValue()
    {
        if (currentValue != -1.0f && field.text != "")
        {
            float oldValue = currentValue;
            float newValue = 0;
            if (slider.value == oldValue)
            {
                newValue = Mathf.Clamp(
                    float.Parse(field.text),
                    slider.minValue,
                    slider.maxValue);

                slider.value = newValue;
                field.text = newValue.ToString();
            }
            else
            {
                newValue = slider.value;

                field.text = newValue.ToString();
            }

            currentValue = newValue;
            PlayerPrefs.SetFloat(key, newValue);
            Logger.Log(this, "Updated value: " + key + " to: " + newValue.ToString());
            if (sliderType == PreciseSliderType.audio)
            {
                GameObject.Find("Scene Manager").GetComponent<Scene_Manager>().InitializeAudio();
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Precise_Slider : MonoBehaviour
{
    [Header("Exposed Variables")]
    [SerializeField] private string key;
    [SerializeField] private string text;
    [SerializeField] private float minValue;
    [SerializeField] private float maxValue;
    [SerializeField] private PreciseSliderType sliderType;

    [Header("Component References")]
    [SerializeField] private Slider slider;
    [SerializeField] private InputField field;
    [SerializeField] private Text textUI;

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

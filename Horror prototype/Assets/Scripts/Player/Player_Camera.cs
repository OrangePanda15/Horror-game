using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Camera : MonoBehaviour
{
    [Header("Variables")]
    public float sensitivity;
    [Range(0.0f, 90.0f)] public float verticalRotationClamp = 85.0f;

    [Header("Component References")]
    public Transform neck;
    public Camera cam;

    // Internal variables
    Vector2 inputRotation;
    Vector2 totalRotation = Vector2.zero;

    private void OnEnable()
    {
        sensitivity = PlayerPrefs.GetFloat(Input_Manager.keys.Input_Mouse_Sensitivity.ToString());
    }

    void Update()
    {
        if (Game_Manager.gameMode == Game_Manager.GameMode.normal)
        {
            inputRotation = Input_Manager.MouseDelta();

            totalRotation += sensitivity * inputRotation;
            totalRotation.y = Mathf.Clamp(totalRotation.y, -verticalRotationClamp, verticalRotationClamp);

            neck.eulerAngles = new Vector3(
                0.0f,
                totalRotation.x,
                0.0f);

            cam.transform.localEulerAngles = new Vector3(
                totalRotation.y,
                0.0f,
                0.0f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Camera : MonoBehaviour
{
    // Exposed variables
    public float sensitivity;
    [Range(0.0f, 90.0f)] public float verticalRotationClamp = 85.0f;

    // Component references
    public Transform neck;
    public Camera cam;

    // Internal variables
    Vector2 inputRotation;
    Vector2 totalRotation = Vector2.zero;

    void Update()
    {
        inputRotation = new Vector2(Input.GetAxisRaw("Mouse X"), -Input.GetAxisRaw("Mouse Y"));

        totalRotation += sensitivity * new Vector2(Input.GetAxisRaw("Mouse X"), -Input.GetAxisRaw("Mouse Y"));
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

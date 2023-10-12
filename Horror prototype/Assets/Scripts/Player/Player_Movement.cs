using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [Header("Variables")]
    public float speedWalk;
    public float speedRun;

    [Header("Component References")]
    public Rigidbody rb;
    public Transform neck;

    // Internal variables
    Vector2 inputMovement;
    bool inputRun;
    Vector3 momentum;

    void Update()
    {
        inputMovement = Input_Manager.Movement();
    }

    private void FixedUpdate()
    {
        if (Game_Manager.gameMode == Game_Manager.GameMode.normal)
        {
            momentum = neck.transform.forward * inputMovement.y + neck.transform.right * inputMovement.x;
            momentum *= inputRun ? speedRun : speedWalk;
            rb.MovePosition(rb.position + momentum * Time.deltaTime);
            rb.velocity = Vector3.zero;
        }
    }
}

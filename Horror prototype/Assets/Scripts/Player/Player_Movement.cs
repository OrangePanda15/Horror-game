using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // Exposed variables
    public float speedWalk;
    public float speedRun;

    // Component references
    public Rigidbody rb;
    public Transform neck;

    // Internal variables
    Vector2 inputMovement;
    bool inputRun;
    Vector3 momentum;

    void Update()
    {
        inputMovement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        if (Game_Manager.gameMode == Game_Manager.GameMode.normal)
        {
            momentum = neck.transform.forward * inputMovement.y + neck.transform.right * inputMovement.x;
            momentum *= inputRun ? speedRun : speedWalk;
            rb.MovePosition(rb.position + momentum * Time.deltaTime);
        }
    }
}

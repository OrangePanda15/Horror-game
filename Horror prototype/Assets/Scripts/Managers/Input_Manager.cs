using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Input_Manager
{
    public static bool Interact()
    {
        return Input.GetKeyDown(KeyCode.E);
    }

    public static Vector2 Movement()
    {
        return new Vector2(
            Convert.ToInt32(Input.GetKey(KeyCode.D)) - Convert.ToInt32(Input.GetKey(KeyCode.A)),
            Convert.ToInt32(Input.GetKey(KeyCode.W)) - Convert.ToInt32(Input.GetKey(KeyCode.S)));
    }
}

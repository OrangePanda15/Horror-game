using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Interact : MonoBehaviour
{
    // Internal variables
    IInteractable currentInteractable;
    bool canInteract;

    private void Update()
    {
        if (canInteract && Input.GetAxisRaw("Interact") > 0.0f)
        {
            currentInteractable.Interact();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        currentInteractable = other.GetComponentInParent<IInteractable>();
        canInteract = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (currentInteractable == other.GetComponentInParent<IInteractable>())
        {
            canInteract = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Interact : MonoBehaviour
{
    // Internal variables
    List<IInteractable> interactables = new List<IInteractable>();

    private void Update()
    {
        if (interactables.Count > 0 && Input_Manager.Interact())
        {
            Logger.Log(this, "Interacted with: " + interactables[interactables.Count - 1].ToString());
            interactables[interactables.Count - 1].Interact();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!(other.GetComponentInParent<IInteractable>() is null))
        {
            interactables.Add(other.GetComponentInParent<IInteractable>());
            Logger.Log(this, "Added item: '" + other.GetComponentInParent<IInteractable>().GetType().ToString() + "' to list of interactables");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        interactables.Remove(other.GetComponentInParent<IInteractable>());
    }
}

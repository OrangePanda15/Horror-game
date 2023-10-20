using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Interact : MonoBehaviour
{
    [Header("Exposed Variables")]
    public float interactDistance;
    public LayerMask interactionMask;

    [Header("Component References")]
    public Camera cam;

    // Internal variables
    GameObject currentObject;
    IInteractable currentInteractable;
    Outline interactableOutline;
    bool canInteract;

    private void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit hit;
        canInteract = Physics.Raycast(ray.origin, ray.direction, out hit, interactDistance, interactionMask);

        try
        {
            if (!canInteract || currentObject != hit.collider.gameObject)
            {
                interactableOutline.enabled = false;
            }
        }
        catch
        {

        }

        if (canInteract)
        {
            currentObject = hit.collider.gameObject;
            currentInteractable = currentObject.GetComponentInParent<IInteractable>();
            interactableOutline = currentInteractable.outline;

            interactableOutline.enabled = true;

            if (Input_Manager.Interact())
            {
                Logger.Log(this, "Interacted with: " + currentInteractable.ToString());
                currentInteractable.Interact();
            }
        }
    }
}

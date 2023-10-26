using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Interact : MonoBehaviour
{
    [Header("Exposed Variables")]
    [SerializeField] private float interactDistance;
    [SerializeField] private LayerMask interactionMask;

    [Header("Asset References")]
    [SerializeField] private Interactable_Info[] interactableInfo;

    [Header("Component References")]
    [SerializeField] private Camera cam;
    [SerializeField] private GameObject interactPrompt;
    [SerializeField] private Text interactPromptInputText;

    // Internal variables
    GameObject currentObject;
    IInteractable currentInteractable;
    Outline interactableOutline;
    bool canInteract;

    private void Start()
    {
        interactPromptInputText.text = Input_Manager.findInputByAction(Input_Manager.keys.Input_Interact).ToString();
        interactPrompt.SetActive(false);
    }

    private void Update()
    {
        if (Game_Manager.GetCurrentGameMode() == Game_Manager.GameMode.normal)
        {
            Ray ray = new Ray(cam.transform.position, cam.transform.forward);
            RaycastHit hit;
            canInteract = Physics.Raycast(ray.origin, ray.direction, out hit, interactDistance, interactionMask);

            try
            {
                if (!canInteract || currentObject != hit.collider.gameObject)
                {
                    interactableOutline.enabled = false;
                    interactPrompt.SetActive(false);
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
                interactPrompt.SetActive(true);

                if (Input_Manager.Interact())
                {
                    Logger.Log(this, "Interacted with: " + currentInteractable.ToString());
                    currentInteractable.Interact();
                }
            }
        }
    }

    public void RefreshInteractPrompt()
    {
        interactPromptInputText.text = Input_Manager.findInputByAction(Input_Manager.keys.Input_Interact).ToString();
    }
}
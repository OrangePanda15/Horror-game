using UnityEngine;

public class Interactable_Null : MonoBehaviour, IInteractable
{
    public Interactable.Interactables type { get; set; }
    public Outline outline { get; set; }
    public void Interact()
    {

    }
}

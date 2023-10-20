using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    Outline outline { get; set; }
    void Interact();
}

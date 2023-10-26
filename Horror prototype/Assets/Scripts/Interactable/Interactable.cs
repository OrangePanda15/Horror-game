using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    Outline outline { get; set; }
    Interactable.Interactables type { get; set; }
    void Interact();
}

public class Interactable
{
    public enum Interactables
    {
        note,
        toggleable
    }
}

[System.Serializable]
public struct Interactable_Info
{
    public Interactable.Interactables type;
    public Sprite interactUISprite;
}
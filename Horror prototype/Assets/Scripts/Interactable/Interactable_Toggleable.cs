using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable_Toggleable : MonoBehaviour, IInteractable
{
    [field: Header("Exposed Variables")]
    [field: SerializeField]
    public Interactable.Interactables type { get; set; }

    [Header("Asset References")]
    public AudioClip[] audioClipsActivate;
    public AudioClip[] audioClipsDeactivate;

    [Header("Component References")]
    public Animator animator;
    public AudioSource audioSource;
    public Outline outline { get; set; }

    // Internal Variables
    bool active;

    private void Start()
    {
        outline = GetComponent<Outline>();
    }

    public void Interact()
    {
        active = !active;
        animator.SetBool("Active", active);
        if (active)
            audioSource.clip = Orange_Lib.GetRandomItemInArray(audioClipsActivate);
        else
            audioSource.clip = Orange_Lib.GetRandomItemInArray(audioClipsDeactivate);
        audioSource.Play();
    }
}

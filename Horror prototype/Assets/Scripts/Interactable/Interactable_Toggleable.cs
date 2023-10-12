using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable_Toggleable : MonoBehaviour, IInteractable
{
    [Header("Asset References")]
    public AudioClip[] audioClipsActivate;
    public AudioClip[] audioClipsDeactivate;

    [Header("Component References")]
    public Animator animator;
    public AudioSource audioSource;

    // Internal Variables
    bool active;

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

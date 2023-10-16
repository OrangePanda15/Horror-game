using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable_Note : MonoBehaviour, IInteractable
{
    [Header("Variables")]
    [TextArea] public string noteText;
    [Header("Asset References")]
    public AudioClip[] audioClipsActivate;
    public AudioClip[] audioClipsDeactivate;

    [Header("Component References")]
    public TextMesh text3d;
    public GameObject canvas;
    public Text textUI;
    public AudioSource audioSource;

    void Start()
    {
        text3d.text = noteText;
        textUI.text = noteText;
        canvas.SetActive(false);
    }

    public void Interact()
    {
        Logger.Log(this, noteText);
        canvas.SetActive(true);
        Game_Manager.UpdateGameMode(Game_Manager.GameMode.ui);
        audioSource.clip = Orange_Lib.GetRandomItemInArray(audioClipsActivate);
        audioSource.Play();
    }

    public void Close()
    {
        Logger.Log(this, "Note closed");
        canvas.SetActive(false);
        Game_Manager.UpdateGameMode(Game_Manager.GameMode.normal);
        audioSource.clip = Orange_Lib.GetRandomItemInArray(audioClipsDeactivate);
        audioSource.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable_Note : MonoBehaviour, IInteractable
{
    // Exposed variables
    [TextArea] public string noteText;

    // Component references
    public TextMesh text3d;
    public GameObject canvas;
    public Text textUI;

    // Internal variables

    void Start()
    {
        text3d.text = noteText;
        textUI.text = noteText;
        canvas.SetActive(false);
    }

    public void Interact()
    {
        Debug.Log(noteText);
        canvas.SetActive(true);
        Game_Manager.gameMode = Game_Manager.GameMode.ui;
    }

    public void Close()
    {
        canvas.SetActive(false);
        Game_Manager.gameMode = Game_Manager.GameMode.normal;
    }
}

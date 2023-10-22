using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable_Note : MonoBehaviour, IInteractable
{
    [Header("Variables")]
    [TextArea] public string noteText;
    public float textUIpadding;
    [Header("Asset References")]
    public AudioClip[] audioClipsActivate;
    public AudioClip[] audioClipsDeactivate;

    [Header("Component References")]
    public TextMesh text3d;
    public GameObject canvas;
    public Text textUI;
    public Image backgroundUI;
    public AudioSource audioSource;
    public Outline outline { get; set; }

    void Start()
    {
        text3d.text = noteText;
        textUI.text = noteText;
        canvas.SetActive(false);

        outline = GetComponent<Outline>();

        SetTextUIAnchors();
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

    public void SetTextUIAnchors()
    {
        float backgroundAspect = backgroundUI.rectTransform.rect.width / backgroundUI.rectTransform.rect.height;
        float imageAspect = backgroundUI.sprite.rect.width / backgroundUI.sprite.rect.height;
        float ratio = imageAspect / backgroundAspect;

        float centerOffset = 0.5f * ratio;

        textUI.rectTransform.anchorMin = new Vector2(0.5f - centerOffset, 0.0f);
        textUI.rectTransform.anchorMax = new Vector2(0.5f + centerOffset, 1.0f);

        textUI.rectTransform.offsetMin = new Vector2(textUIpadding, -textUIpadding);
        textUI.rectTransform.offsetMax = new Vector2(-textUIpadding, -textUIpadding);

        Logger.Log(this, "Text UI anchors: " +
            textUI.rectTransform.anchorMin.x.ToString() + ", " +
            textUI.rectTransform.anchorMin.y.ToString() + ", " +
            textUI.rectTransform.anchorMax.x.ToString() + ", " +
            textUI.rectTransform.anchorMax.y.ToString());
    }    
}

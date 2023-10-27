using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Interactable_Note : MonoBehaviour, IInteractable
{
    [field: Header("Exposed Variables")]
    [field: SerializeField] public Interactable.Interactables type { get; set; }
    [SerializeField] [TextArea] private string noteText;
    [SerializeField] [Range(0.0f, 0.5f)] private float textPadding;
    [SerializeField] private float modelScale;
    [Header("Asset References")]
    [SerializeField] private Sprite background;
    [SerializeField] private AudioClip[] audioClipsActivate;
    [SerializeField] private AudioClip[] audioClipsDeactivate;

    [Header("Component References")]
    [SerializeField] private TextMeshPro textTMP3D;
    [SerializeField] private TextMeshProUGUI textTMPUI;
    [SerializeField] private GameObject model;
    [SerializeField] private GameObject canvas;
    [SerializeField] private RectTransform textUIContainer;
    [SerializeField] private Image backgroundUI;
    [SerializeField] private AudioSource audioSource;
    public Outline outline { get; set; }

    // Internal Variables
    bool noteOpen = false;
    char[] validLinebreakCharacters = new char[]
    {
        ' ',
        '\n'
    };

    private void OnValidate()
    {
        Logger.Log(this, "Updated note");
        InitializeNote();
    }

    void Start()
    {
        canvas.SetActive(false);
        outline = GetComponent<Outline>();
        InitializeNote();
    }

    void Update()
    {
        if (Input_Manager.Pause() && noteOpen)
        {
            Close();
        }
    }

    public void Interact()
    {
        if (!Game_Manager.UIInUse())
        {
            noteOpen = true;

            Logger.Log(this, noteText);
            canvas.SetActive(true);
            Game_Manager.UpdateGameMode(Game_Manager.GameMode.ui);
            audioSource.clip = Orange_Lib.GetRandomItemInArray(audioClipsActivate);
            audioSource.Play();
            Game_Manager.SetUIUsage(true);
        }
    }

    public void Close()
    {
        noteOpen = false;

        Logger.Log(this, "Note closed");
        canvas.SetActive(false);
        Game_Manager.UpdateGameMode(Game_Manager.GameMode.normal);
        audioSource.clip = Orange_Lib.GetRandomItemInArray(audioClipsDeactivate);
        audioSource.Play();
        Game_Manager.SetUIUsage(false);
    }

    public void InitializeNote()
    {
        backgroundUI.sprite = background;
        SetTextUIAnchors();
        ScaleModel();
        AssignText(noteText);
    }

    void SetTextUIAnchors()
    {
        float backgroundAspect = backgroundUI.rectTransform.rect.width / backgroundUI.rectTransform.rect.height;
        float imageAspect = backgroundUI.sprite.rect.width / backgroundUI.sprite.rect.height;
        float ratio = imageAspect / backgroundAspect;

        float centerOffset = 0.5f * ratio;

        textUIContainer.anchorMin = new Vector2(0.5f - centerOffset, 0.0f);
        textUIContainer.anchorMax = new Vector2(0.5f + centerOffset, 1.0f);
        textUIContainer.offsetMin = Vector2.zero;
        textUIContainer.offsetMax = Vector2.zero;

        textUIContainer.offsetMin = Vector2.zero;
        textUIContainer.offsetMax = Vector2.zero;

        textTMPUI.rectTransform.anchorMin = new Vector2(textPadding, 2.0f * textPadding);
        textTMPUI.rectTransform.anchorMax = new Vector2(1.0f - textPadding, 1.0f - textPadding);
    }   
    
    void ScaleModel()
    {
        Vector3 dimensions = modelScale * new Vector2(backgroundUI.sprite.rect.width / backgroundUI.sprite.rect.height, 1.0f);
        model.transform.localScale = new Vector3(dimensions.x, 1.0f, dimensions.y);
        textTMP3D.rectTransform.sizeDelta = 10.0f * dimensions;
        textTMP3D.rectTransform.sizeDelta -= 0.5f * new Vector2(textPadding, textPadding);
        textTMP3D.rectTransform.sizeDelta *= 25.0f;
        textTMP3D.fontSize = 10.0f * dimensions.y;
    }

    void AssignText(string text)
    {
        textTMP3D.text = text;
        textTMPUI.text = text;
    }
}

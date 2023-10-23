using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable_Note : MonoBehaviour, IInteractable
{
    [Header("Variables")]
    [TextArea] public string noteText;
    [Range(0.0f, 0.5f)] public float textPadding;
    public float characterSize;
    public float modelScale;
    [Header("Asset References")]
    public Font font;
    public AudioClip[] audioClipsActivate;
    public AudioClip[] audioClipsDeactivate;

    [Header("Component References")]
    public TextMesh text3d;
    public GameObject model;
    public GameObject canvas;
    public RectTransform textUIContainer;
    public Text textUI;
    public Image backgroundUI;
    public AudioSource audioSource;
    public Outline outline { get; set; }

    // Internal Variables
    char[] validLinebreakCharacters = new char[]
    {
        ' ',
        '\n'
    };

    void Start()
    {
        InitializeNote();
        canvas.SetActive(false);
        outline = GetComponent<Outline>();
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

    public void InitializeNote()
    {
        text3d.text = noteText;
        textUI.text = noteText;
        text3d.font = font;
        textUI.font = font;
        SetTextUIAnchors();
        ScaleModel();
        NormalizeTextSizes();
        HandleTextWrapping();
    }

    public void SetTextUIAnchors()
    {
        float backgroundAspect = backgroundUI.rectTransform.rect.width / backgroundUI.rectTransform.rect.height;
        float imageAspect = backgroundUI.sprite.rect.width / backgroundUI.sprite.rect.height;
        float ratio = imageAspect / backgroundAspect;

        float centerOffset = 0.5f * ratio;

        textUIContainer.anchorMin = new Vector2(0.5f - centerOffset, 0.0f);
        textUIContainer.anchorMax = new Vector2(0.5f + centerOffset, 1.0f);
        textUIContainer.offsetMin = Vector2.zero;
        textUIContainer.offsetMax = Vector2.zero;

        textUI.rectTransform.anchorMin = new Vector2(textPadding, textPadding);
        textUI.rectTransform.anchorMax = Vector2.one - new Vector2(textPadding, textPadding);
        textUIContainer.offsetMin = Vector2.zero;
        textUIContainer.offsetMax = Vector2.zero;
    }   
    
    public void ScaleModel()
    {
        Vector3 dimensions = modelScale * new Vector2(backgroundUI.sprite.rect.width / backgroundUI.sprite.rect.height, 1.0f);
        model.transform.localScale = new Vector3(dimensions.x, 1.0f, dimensions.y);
        text3d.transform.localPosition = 5.0f * new Vector3(dimensions.x, dimensions.y, 0.0f);
        text3d.transform.localPosition *= 1.0f - (2.0f * textPadding);
    }

    public void NormalizeTextSizes()
    {
        text3d.characterSize = characterSize * 4.0f * model.transform.localScale.z;
        textUI.fontSize = Mathf.RoundToInt(characterSize * backgroundUI.rectTransform.rect.height);
    }

    public void HandleTextWrapping()
    {
        float fontSizeRatio = textUI.fontSize / font.fontSize;
        string[] words = noteText.Split(validLinebreakCharacters, System.StringSplitOptions.RemoveEmptyEntries);

        string output = "";
        int maxLineCount = Mathf.FloorToInt((1.0f - (2.0f * textPadding)) / characterSize);
        int currentLineCount = 0;
        string currentLine = "";
        float maxLineWidth = textUI.rectTransform.rect.width;
        float currentLineWidth = 0.0f;
        for (int i = 0; i < words.Length && currentLineCount < maxLineCount; i++)
        {
            float wordWidth = 0.0f;
            CharacterInfo charInfo;
            foreach (char letter in words[i])
            {
                font.GetCharacterInfo(letter, out charInfo);
                float letterWidth = charInfo.advance * fontSizeRatio;
                wordWidth += letterWidth;
            }
            font.GetCharacterInfo(' ', out charInfo);
            wordWidth += charInfo.advance;
            Logger.Log(this, wordWidth.ToString() + " " + words[i]);

            if (wordWidth + currentLineWidth < maxLineWidth)
            {
                currentLine += words[i] + " ";
                currentLineWidth += wordWidth;
            }
            else
            {
                Logger.Log(this, currentLineWidth.ToString() + ": " + currentLine);
                output += "\n" + currentLine;
                currentLine = "";
                currentLineWidth = wordWidth;
                currentLineCount++;
            }
        }

        textUI.text = output;
        text3d.text = output;
    }
}

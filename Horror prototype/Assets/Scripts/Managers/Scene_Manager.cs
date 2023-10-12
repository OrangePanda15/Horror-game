using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene_Manager : MonoBehaviour
{
    [Header("Component References")]
    public GameObject loadingScreen;
    public Slider loadingBar;

    private void OnEnable()
    {
        if (Game_Manager.sceneManager is null)
            Game_Manager.sceneManager = this;
        else
            Destroy(gameObject);
        DontDestroyOnLoad(this);
    }

    public void LoadScene(string newScene)
    {
        loadingScreen.SetActive(true);

        StartCoroutine(LoadAsync(newScene));
    }

    public IEnumerator LoadAsync(string newScene)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(newScene);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress * 1.1111111111111111111111111111111f);
            Logger.Log(this, "Progress: " + progress);
            loadingBar.value = progress;

            yield return null;
        }

        loadingScreen.SetActive(false);
    }
}

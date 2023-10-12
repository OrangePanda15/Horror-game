using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Settings : MonoBehaviour
{
    [Header("Component References")]
    public GameObject[] tabs;

    // Internal Variables
    int currentTab = 0;

    private void OnEnable()
    {
        foreach (GameObject tab in tabs)
        {
            tab.SetActive(false);
        }

        tabs[currentTab].SetActive(true);
    }

    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void SelectNewTab(int tab)
    {
        tabs[currentTab].SetActive(false);
        currentTab = tab;
        tabs[currentTab].SetActive(true);
    }

    public void CloseMenu()
    {
        gameObject.SetActive(false);
    }
}

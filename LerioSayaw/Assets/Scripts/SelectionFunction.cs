using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionFunction : MonoBehaviour
{
    [SerializeField] private GameObject[] listOfPanels;
    private int currentIndex = 0;

    void Start()
    {
        UpdatePanelSelection();
    }

    public void NextBtn()
    {
        currentIndex = (currentIndex + 1) % listOfPanels.Length;
        UpdatePanelSelection();
    }

    public void PreviousBtn()
    {
        currentIndex = (currentIndex - 1 + listOfPanels.Length) % listOfPanels.Length;
        UpdatePanelSelection();
    }

    private void UpdatePanelSelection()
    {
        for (int i = 0; i < listOfPanels.Length; i++)
        {
            listOfPanels[i].SetActive(i == currentIndex);
        }
    }
}

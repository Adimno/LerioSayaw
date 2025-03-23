using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PerformanceTotal : MonoBehaviour
{
    //carinosa dance checker
    public Toggle carinosaFigureOne;
    public Toggle carinosaFigureTwo;
    public Toggle carinosaFigureThree;
    public Toggle carinosaFigureFour;
    public Toggle carinosaFigureFive;
    public Toggle carinosaFigureSix;
    public Toggle carinosaFigureSeven;
    public Toggle carinosaFigureEight;

    //lerion dance check
    public Toggle lerionFigureOne;
    public Toggle lerionFigureTwo;
    public Toggle lerionFigureThree;
    public Toggle lerionFigureFour;
    public Toggle lerionFigureFive;
    public Toggle lerionFigureSix;

    public Toggle carinosaFigureOneV2;
    public Toggle carinosaFigureTwoV2;
    public Toggle carinosaFigureThreeV2;
    public Toggle carinosaFigureFourV2;
    public Toggle carinosaFigureFiveV2;
    public Toggle carinosaFigureSixV2;
    public Toggle carinosaFigureSevenV2;
    public Toggle carinosaFigureEightV2;

    public Toggle lerionFigureOneV2;
    public Toggle lerionFigureTwoV2;
    public Toggle lerionFigureThreeV2;
    public Toggle lerionFigureFourV2;
    public Toggle lerionFigureFiveV2;
    public Toggle lerionFigureSixV2;


    // Start is called before the first frame update
    void Start()
    {
        // Check Carinosa Figures
        CheckToggleStatus(carinosaFigureOne, "woman_carinosa_figure1");
        CheckToggleStatus(carinosaFigureTwo, "woman_carinosa_figure2");
        CheckToggleStatus(carinosaFigureThree, "woman_carinosa_figure3");
        CheckToggleStatus(carinosaFigureFour, "woman_carinosa_figure4");
        CheckToggleStatus(carinosaFigureFive, "woman_carinosa_figure5");
        CheckToggleStatus(carinosaFigureSix, "woman_carinosa_figure6");
        CheckToggleStatus(carinosaFigureSeven, "woman_carinosa_figure7");
        CheckToggleStatus(carinosaFigureEight, "woman_carinosa_figure8");

        // Check Lerion Figures
        CheckToggleStatus(lerionFigureOne, "woman_lerion_figure1");
        CheckToggleStatus(lerionFigureTwo, "woman_lerion_figure2");
        CheckToggleStatus(lerionFigureThree, "woman_lerion_figure3");
        CheckToggleStatus(lerionFigureFour, "woman_lerion_figure4");
        CheckToggleStatus(lerionFigureFive, "woman_lerion_figure5");
        CheckToggleStatus(lerionFigureSix, "woman_lerion_figure6");

        CheckToggleStatus(carinosaFigureOneV2, "man_carinosa_figure1");
        CheckToggleStatus(carinosaFigureTwoV2, "man_carinosa_figure2");
        CheckToggleStatus(carinosaFigureThreeV2, "man_carinosa_figure3");
        CheckToggleStatus(carinosaFigureFourV2, "man_carinosa_figure4");
        CheckToggleStatus(carinosaFigureFiveV2, "man_carinosa_figure5");
        CheckToggleStatus(carinosaFigureSixV2, "man_carinosa_figure6");
        CheckToggleStatus(carinosaFigureSevenV2, "man_carinosa_figure7");
        CheckToggleStatus(carinosaFigureEightV2, "man_carinosa_figure8");

        // Check Lerion Figures
        CheckToggleStatus(lerionFigureOneV2, "man_lerion_figure1");
        CheckToggleStatus(lerionFigureTwoV2, "man_lerion_figure2");
        CheckToggleStatus(lerionFigureThreeV2, "man_lerion_figure3");
        CheckToggleStatus(lerionFigureFourV2, "man_lerion_figure4");
        CheckToggleStatus(lerionFigureFiveV2, "man_lerion_figure5");
        CheckToggleStatus(lerionFigureSixV2, "man_lerion_figure6");

    }

    // Method to check PlayerPrefs and update toggle status
    private void CheckToggleStatus(Toggle toggle, string prefKey)
    {
        if (toggle == null) return;

        string value = PlayerPrefs.GetString(prefKey, "");
        if (!string.IsNullOrEmpty(value))
        {
            toggle.isOn = true;
            // Optional: Change color to indicate completion
            ColorBlock colors = toggle.colors;
            colors.normalColor = Color.green;
            colors.selectedColor = Color.green;
            toggle.colors = colors;
        }
        else
        {
            toggle.isOn = false;
        }
    }


    public void ResetAllProgress()
    {
        for (int i = 1; i <= 8; i++)
        {
            PlayerPrefs.DeleteKey("carinosa_figure" + i);
        }

        for (int i = 1; i <= 8; i++)
        {
            PlayerPrefs.DeleteKey("lerion_figure" + i);
        }

        PlayerPrefs.Save();
        Start();
    }

    public void DeleteAllKey()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();

        Debug.Log("All PlayerPrefs data has been deleted");
    }
}
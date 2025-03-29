using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreValue : MonoBehaviour
{
    public TotalPoints points;
    public TextMeshProUGUI textMeshPro;

    void Update()
    {
        // Update the TextMeshPro text with points value
        textMeshPro.text = points.Points.ToString("F2") + "/268";
    }
}

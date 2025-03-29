using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GenderValue : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;

    void Update()
    {
        textMeshPro.text = StartDance.GetGender();

    }
}

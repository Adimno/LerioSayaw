using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarinosaCharacterSelected : MonoBehaviour
{
    [SerializeField] private GameObject femaleCharacter;
    [SerializeField] private GameObject maleCharacter;
    [SerializeField] private GameObject vrPos;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip selectionSound; // Assign your MP3 file here

    public FigureTextTimer figureTextTimer;

    private void Start()
    {
        maleCharacter.SetActive(false);
        femaleCharacter.SetActive(false);
    }

    public void ChosedMale()
    {
       figureTextTimer.figureText.gameObject.SetActive(true);
        figureTextTimer.enabled = true;
        maleCharacter.SetActive(false);
        femaleCharacter.SetActive(true);
        vrPos.transform.position = new Vector3(0.5f, -4.367f, 10.68f);
        vrPos.transform.rotation = Quaternion.Euler(0, 180f, 0);

        PlaySound();
    }

    public void ChosedFemale()
    {
     figureTextTimer.figureText.gameObject.SetActive(true);
        figureTextTimer.enabled = true;
        femaleCharacter.SetActive(false);
        maleCharacter.SetActive(true);
        vrPos.transform.position = new Vector3(-0.124f, -4.367f, 10.68f);
        vrPos.transform.rotation = Quaternion.Euler(0, -1.763f, 0);

        PlaySound();
    }

    private void PlaySound()
    {
        if (audioSource != null && selectionSound != null)
        {
            audioSource.PlayOneShot(selectionSound);
        }
    }
}

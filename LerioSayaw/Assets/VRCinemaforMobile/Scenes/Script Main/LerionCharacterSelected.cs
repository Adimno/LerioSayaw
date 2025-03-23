using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerionCharacterSelected : MonoBehaviour
{
    [SerializeField] private GameObject femaleCharacter;
    [SerializeField] private GameObject maleCharacter;
    [SerializeField] private GameObject vrPos;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip selectionSound; // Assign your MP3 file here

    private void Start()
    {
        maleCharacter.SetActive(false);
        femaleCharacter.SetActive(false);
    }

    public void ChosedMale()
    {
        maleCharacter.SetActive(false);
        femaleCharacter.SetActive(true);
        vrPos.transform.position = new Vector3(0.8f, -4.367f, 10.68f);
        vrPos.transform.rotation = Quaternion.Euler(0,91.904f, 0);

        PlaySound();
    }

    public void ChosedFemale()
    {
        femaleCharacter.SetActive(false);
        maleCharacter.SetActive(true);
        vrPos.transform.position = new Vector3(-0.63f, -4.367f, 10.68f);
        vrPos.transform.rotation = Quaternion.Euler(0, 91.904f, 0);

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

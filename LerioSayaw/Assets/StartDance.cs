using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDance : MonoBehaviour
{
    public GameObject Steps;
    public GameObject MaleSteps;
    public GameObject FemaleSteps;
    public GameObject CharacterSelection;
    public AudioSource music;
    public static string GenderText;

    public AudioSource LerionFemaleMusic;


    public static string GetGender()
    {
        return GenderText;
    }
    // Start is called before the first frame update
    public void Male()
    {
        GenderText = "Male";
        Steps.SetActive(true);
        MaleSteps.SetActive(true);
        FemaleSteps.SetActive(false);
        CharacterSelection.SetActive(false);
        music.Play();
    }
    public void Female()
    {
        GenderText = "Female";
        Steps.SetActive(true);
        MaleSteps.SetActive(false);
        FemaleSteps.SetActive(true);
        CharacterSelection.SetActive(false);
        LerionFemaleMusic.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratsHTP : MonoBehaviour
{
    public GameObject player;
    public DanceCanvasHTP danceCanvasHTP;
    public AudioSource music;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            StartCoroutine(DelayedActions());
        }
    }

    private IEnumerator DelayedActions()
    {
        yield return new WaitForSeconds(2f);
        danceCanvasHTP.CongratsCanvasLogic();
        music.Stop();
    }
}

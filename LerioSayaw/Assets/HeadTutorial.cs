using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadTutorial : MonoBehaviour
{
     public GameObject targetObject; 
    public StepsCheckerTutorial stepChecker;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == targetObject)
        {
            Debug.Log("Head");
            stepChecker.SetIndexTrue(1);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHandTutorial : MonoBehaviour
{
   public GameObject targetObject; 
    public StepsCheckerTutorial stepChecker;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == targetObject)
        {
            Debug.Log("Rights");
            stepChecker.SetIndexTrue(2);
        }
    }
    
}

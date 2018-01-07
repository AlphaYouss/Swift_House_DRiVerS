using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour
{

    
    public GameObject CompleteTrig;
    

    void OnTriggerEnter()
    {
        this.GetComponent<BoxCollider>().enabled = false;
        Application.Quit();
    }

}

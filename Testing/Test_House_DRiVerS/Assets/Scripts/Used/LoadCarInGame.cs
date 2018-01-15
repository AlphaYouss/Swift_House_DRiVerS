using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCarInGame : MonoBehaviour
{

    public GameObject carRavens;
    public GameObject carDragons;
    public GameObject carSerpents;
    public GameObject carVikings;

    // Use this for initialization
    public void Start()
    {
        LoadCar();
    }

    public void LoadCar()
    {
        switch (PlayerPrefs.GetString("car"))
        {
            case "ravens":
                GameObject ravensCar = Instantiate(carRavens);
                carRavens.transform.position = GameObject.Find("SpawnPoint").transform.position;
                carRavens.SetActive(ravensCar);
                break;
            case "dragons":
                GameObject dragonsCar = Instantiate(carDragons);
                carDragons.transform.position = GameObject.Find("SpawnPoint").transform.position;
                carDragons.SetActive(dragonsCar);
                break;
            case "serpents":
                GameObject serpentsCar = Instantiate(carSerpents);
                carSerpents.transform.position = GameObject.Find("SpawnPoint").transform.position;
                carSerpents.SetActive(serpentsCar);
                break;
            case "vikings":
                GameObject vikingsCar = Instantiate(carVikings);
                carVikings.transform.position = GameObject.Find("SpawnPoint").transform.position;
                carVikings.SetActive(vikingsCar);
                break;
        }
    }
}

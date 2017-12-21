using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour
{

    public int MinCount;
    public int SecCount;
    public float MilliCount;

    public int MinCount2;
    public int SecCount2;
    public float MilliCount2;

    public int MinCount3;
    public int SecCount3;
    public float MilliCount3;

    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilliDisplay;

    public GameObject MinDisplay1;
    public GameObject SecDisplay1;
    public GameObject MilliDisplay1;

    public GameObject MinDisplay2;
    public GameObject SecDisplay2;
    public GameObject MilliDisplay2;

    void Start()
    {
        MinCount = PlayerPrefs.GetInt("MinSave");
        SecCount = PlayerPrefs.GetInt("SecSave");
        MilliCount = PlayerPrefs.GetFloat("MilliSave");

        MinCount2 = PlayerPrefs.GetInt("MinSave2");
        SecCount2 = PlayerPrefs.GetInt("SecSave2");
        MilliCount2 = PlayerPrefs.GetFloat("MilliSave2");

        MinCount3 = PlayerPrefs.GetInt("MinSave3");
        SecCount3 = PlayerPrefs.GetInt("SecSave3");
        MilliCount3 = PlayerPrefs.GetFloat("MilliSave3");

        MinDisplay.GetComponent<Text>().text = "" + MinCount + ":";
        SecDisplay.GetComponent<Text>().text = "" + SecCount + ".";
        MilliDisplay.GetComponent<Text>().text = "" + MilliCount;

        MinDisplay1.GetComponent<Text>().text = "" + MinCount2 + ":";
        SecDisplay1.GetComponent<Text>().text = "" + SecCount2 + ".";
        MilliDisplay1.GetComponent<Text>().text = "" + MilliCount2;

        MinDisplay2.GetComponent<Text>().text = "" + MinCount3 + ":";
        SecDisplay2.GetComponent<Text>().text = "" + SecCount3 + ".";
        MilliDisplay2.GetComponent<Text>().text = "" + MilliCount3;

    }
}



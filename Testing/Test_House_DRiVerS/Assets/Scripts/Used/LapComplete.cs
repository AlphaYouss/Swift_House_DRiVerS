using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LapComplete : MonoBehaviour
{

    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;
    public GameObject ThousendDisplay;

    public GameObject MinuteDisplayCurrent;
    public GameObject SecondDisplayCurrent;
    public GameObject MilliDisplayCurrent;
    public GameObject ThousendDisplayCurrent;

    public GameObject LapTimeBox;

    public GameObject lapCounter;
    public int LapsDone;

    public float rawtime;

    public GameObject RaceFinish;


    public int MinCount;
    public int SecCount;
    public float MilliCount;
    public float ThousCount;


    public int MinCount2;
    public int SecCount2;
    public float MilliCount2;
    public float ThousCount2;

    public int MinCount3;
    public int SecCount3;
    public float MilliCount3;
    public float ThousCount3;

    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilliDisplayLaps;
    public GameObject ThousDisplay;

    public GameObject MinDisplay1;
    public GameObject SecDisplay1;
    public GameObject MilliDisplay1;
    public GameObject ThousDisplay1;

    public GameObject MinDisplay2;
    public GameObject SecDisplay2;
    public GameObject MilliDisplay2;
    public GameObject ThousDisplay2;
    
    public float d = 0.5f;
    public void loadFinish()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void OnTriggerEnter()
    {
        LapsDone += 1;
        rawtime = PlayerPrefs.GetFloat("rawtime");
        if (LapTimeManager.rawTime <= rawtime)
        {
         
            
            if(LapTimeManager.MilliCount <= 10)
            {
                MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount + "";
            }
            else
            {
                MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount + "";

            }
            if (LapTimeManager.SecondCount <= 9)
            {
                SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ":";
            }
            else
            {
                SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ":";
            }

            if (LapTimeManager.MinuteCount <= 9)
            {
                MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ":";
            }
            else
            {
                MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ":";
            }

            ThousendDisplay.GetComponent<Text>().text = "" + LapTimeManager.ThousandCount + "";

        }
        PlayerPrefs.SetFloat("rawtime", LapTimeManager.rawTime);

        if (LapsDone == 1)
        {
            PlayerPrefs.SetInt("MinSave", LapTimeManager.MinuteCount);
            PlayerPrefs.SetInt("SecSave", LapTimeManager.SecondCount);
            PlayerPrefs.SetFloat("MilliSave", LapTimeManager.MilliCount);
            PlayerPrefs.SetFloat("ThousSave", LapTimeManager.ThousandCount);

            MinCount = PlayerPrefs.GetInt("MinSave");
            SecCount = PlayerPrefs.GetInt("SecSave");
            MilliCount = PlayerPrefs.GetFloat("MilliSave");
            ThousCount = PlayerPrefs.GetFloat("ThousSave");


            if(MinCount <= 9)
            {
                MinDisplay.GetComponent<Text>().text = "0" + MinCount + ":";
            }
            else
            {
                MinDisplay.GetComponent<Text>().text = "" + MinCount + ":";
            }
            if (SecCount <= 9)
            {
                SecDisplay.GetComponent<Text>().text = "0" + SecCount + ":";
            }
            else
            {
                SecDisplay.GetComponent<Text>().text = "" + SecCount + ":";
            }
           
            MilliDisplayLaps.GetComponent<Text>().text = "" + MilliCount;
            ThousDisplay.GetComponent<Text>().text = "" + ThousCount;

            if (MinCount <= 9)
            {
                MinuteDisplay.GetComponent<Text>().text = "0" + MinCount + ":";
            }
            else
            {
                MinuteDisplay.GetComponent<Text>().text = "" + MinCount + ":";
            }
            if(SecCount <= 9)
            {
                SecondDisplay.GetComponent<Text>().text = "0" + SecCount + ":";
            }
            else{
                SecondDisplay.GetComponent<Text>().text = "" + SecCount + ":";
            }
            MilliDisplay.GetComponent<Text>().text = "" + MilliCount;
            ThousendDisplay.GetComponent<Text>().text = "" + ThousCount;

        }


        if (LapsDone == 2)
        {

            PlayerPrefs.SetInt("MinSave2", LapTimeManager.MinuteCount);
            PlayerPrefs.SetInt("SecSave2", LapTimeManager.SecondCount);
            PlayerPrefs.SetFloat("MilliSave2", LapTimeManager.MilliCount);
            PlayerPrefs.SetFloat("ThousSave2", LapTimeManager.ThousandCount);


            MinCount2 = PlayerPrefs.GetInt("MinSave2");
            SecCount2 = PlayerPrefs.GetInt("SecSave2");
            MilliCount2 = PlayerPrefs.GetFloat("MilliSave2");
            ThousCount2 = PlayerPrefs.GetFloat("ThousSave2");

            if(MinCount2 <= 9)
            {
                MinDisplay1.GetComponent<Text>().text = "0" + MinCount2 + ":";
            }
            else
            {
                MinDisplay1.GetComponent<Text>().text = "" + MinCount2 + ":";
            }
            if (SecCount2 <= 9)
            {
                SecDisplay1.GetComponent<Text>().text = "0" + SecCount2 + ":";
            }
            else
            {
                SecDisplay1.GetComponent<Text>().text = "" + SecCount2 + ":";
            }
            MilliDisplay1.GetComponent<Text>().text = "" + MilliCount2;
            ThousDisplay1.GetComponent<Text>().text = "" + ThousCount2;

        }

        if (LapsDone == 3){
            PlayerPrefs.SetInt("MinSave3", LapTimeManager.MinuteCount);
            PlayerPrefs.SetInt("SecSave3", LapTimeManager.SecondCount);
            PlayerPrefs.SetFloat("MilliSave3", LapTimeManager.MilliCount);
            PlayerPrefs.SetFloat("ThousSave3", LapTimeManager.ThousandCount);


            MinCount3 = PlayerPrefs.GetInt("MinSave3");
            SecCount3 = PlayerPrefs.GetInt("SecSave3");
            MilliCount3 = PlayerPrefs.GetFloat("MilliSave3");
            ThousCount3 = PlayerPrefs.GetFloat("ThousSave3");

            if (MinCount3 <= 9)
            {
                MinDisplay2.GetComponent<Text>().text = "0" + MinCount3 + ":";
            }
            else
            {
                MinDisplay2.GetComponent<Text>().text = "" + MinCount3 + ":";
            }
            if (SecCount3 <= 9)
            {
                SecDisplay2.GetComponent<Text>().text = "0" + SecCount3 + ":";
            }
            else
            {
                SecDisplay2.GetComponent<Text>().text = "" + SecCount3 + ":";
            }
            
            MilliDisplay2.GetComponent<Text>().text = "" + MilliCount3;
            ThousDisplay2.GetComponent<Text>().text = "" + ThousCount3;

            LapTimeBox.SetActive(false);
            MinuteDisplayCurrent.GetComponent<Text>().text = "00:";
            SecondDisplayCurrent.GetComponent<Text>().text = "00:";
            MilliDisplayCurrent.GetComponent<Text>().text = "0:";
            ThousendDisplayCurrent.GetComponent<Text>().text = "0";

        }

        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;
        LapTimeManager.ThousandCount = 0;
        LapTimeManager.rawTime = 0;
        lapCounter.GetComponent<Text>().text = "" + LapsDone;
        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);

        if (LapsDone == 3)
        {
            RaceFinish.SetActive(true);
            LapTimeBox.SetActive(false);
            loadFinish();
        }
    }
   
}

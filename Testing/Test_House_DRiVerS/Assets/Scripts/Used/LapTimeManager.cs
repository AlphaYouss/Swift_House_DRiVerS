using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{

    public static int MinuteCount;
    public static int SecondCount;
    public static float MilliCount;
    public static float ThousandCount;
    public static string ThousandDisplay;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;
    public GameObject ThousandBox;

    public static float rawTime;
    void Update()
    {
        
        ThousandCount += Time.deltaTime * 100;
        rawTime += Time.deltaTime;
        ThousandDisplay = ThousandCount.ToString("F0");
        ThousandBox.GetComponent<Text>().text = "" + ThousandDisplay;

        if (ThousandCount >= 10)
        {
            MilliCount += 1;
            ThousandCount = 0;
        }
        if (MilliCount >= 10)
        {
            MilliCount = 0;
            SecondCount += 1;
            MilliBox.GetComponent<Text>().text = "0" + MilliCount + "";
        }
        else
        {
            MilliBox.GetComponent<Text>().text = "" + MilliCount + "";
        }
        if (SecondCount <= 9)
        {
            SecondBox.GetComponent<Text>().text = "0" + SecondCount + ":";
        }
        else
        {
            SecondBox.GetComponent<Text>().text = "" + SecondCount + ":";
        }

        if (SecondCount >= 60)
        {
            SecondCount = 0;
            MinuteCount += 1;
        }

        if (MinuteCount <= 9)
        {
            MinuteBox.GetComponent<Text>().text = "0" + MinuteCount + ":";
        }
        else
        {
            MinuteBox.GetComponent<Text>().text = "" + MinuteCount + ":";
        }

    }
}

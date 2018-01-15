using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Xml;
using System;
public class LapComplete : MonoBehaviour
{

    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;
    public GameObject car;
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

    public int totalMin;
    public int totalHours;
    public int totalSeconds;
    public float totalMilliSeconds;
    public float totalThousendSeconds;

    public int attempt;

    public float d = 0.5f;
    public void loadFinish()
    {
        SceneManager.LoadScene("finish");
    }

    void OnTriggerEnter()
    {
        LapsDone += 1;
        rawtime = PlayerPrefs.GetFloat("rawtime");
        if (LapTimeManager.rawTime <= rawtime)
        {


            if (LapTimeManager.MilliCount <= 10)
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


            if (MinCount <= 9)
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
            if (SecCount <= 9)
            {
                SecondDisplay.GetComponent<Text>().text = "0" + SecCount + ":";
            }
            else
            {
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

            if (MinCount2 <= 9)
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

        if (LapsDone == 3)
        {
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
            SaveTimeTotal();
            SaveTotalTime();
            RaceFinish.SetActive(true);
            LapTimeBox.SetActive(false);
            loadFinish();
        }
    }
    public void SaveTimeTotal()
    {
        totalMin = MinCount + MinCount2 + MinCount3;
        totalSeconds = SecCount + SecCount2 + SecCount3;
        totalMilliSeconds = MilliCount + MilliCount2 + MilliCount3;
        totalThousendSeconds = ThousCount + ThousCount2 + ThousCount3;
    }
    //public void getAttempts()
    //{
     //   XmlDocument doc = new XmlDocument();
     //   doc.Load("racegame.xml");
     //   if (attempt != 0)
    //    {
    //        XmlNodeList userNodes = doc.SelectNodes("//trial/Attempt");
    //        foreach (XmlNode userNode in userNodes)
    //        {
    //            attempt++;
     //           doc.Save("racegame.xml");
     //       }
     //   }
        
        
   // }
    public void SaveTotalTime()
    {
        attempt++;
        XmlDocument xmlDoc = new XmlDocument();

        xmlDoc.Load("racegame.xml");

        XmlNode node = xmlDoc.CreateNode(XmlNodeType.Element, "trial", null);

        XmlNode root = xmlDoc.DocumentElement;

        XmlNode userNode1 = xmlDoc.CreateElement("track");

        XmlAttribute attribute5 = xmlDoc.CreateAttribute("Track");
        attribute5.Value = SceneManager.GetActiveScene().name;
        userNode1.Attributes.Append(attribute5);
        node.AppendChild(userNode1);

        string RacedWithCar =  car.name;
        XmlNode userNode2 = xmlDoc.CreateElement("Car");

        XmlAttribute attribute6 = xmlDoc.CreateAttribute("Car");
        attribute6.Value = RacedWithCar;
        userNode2.Attributes.Append(attribute6);
        node.AppendChild(userNode2);

        

        //XmlAttribute attribute7 = xmlDoc.CreateAttribute("Attempt");
        //getAttempts();
        //string attempts = attempt.ToString();
        //attribute7.Value = attempts;
        //userNode3.Attributes.Append(attribute7);
        //node.AppendChild(userNode3);

        XmlNode userNode = xmlDoc.CreateElement("time");

        XmlAttribute attribute4 = xmlDoc.CreateAttribute("hours");
        attribute4.Value = totalHours.ToString();
        userNode.Attributes.Append(attribute4);
        node.AppendChild(userNode);



        XmlAttribute attribute1 = xmlDoc.CreateAttribute("sec");
        if (totalSeconds > 60)
        {
            totalMin++;
            totalSeconds -= 60;
            if (totalSeconds > 60)
            {
                totalMin++;
                totalSeconds -= 60;
                attribute1.Value = totalSeconds.ToString();
            }
            else
            {
                attribute1.Value = totalSeconds.ToString();
            }
        }
        else
        {
            attribute1.Value = totalSeconds.ToString();
        }

        userNode.Attributes.Append(attribute1);
        node.AppendChild(userNode);

        XmlAttribute attribute = xmlDoc.CreateAttribute("min");
        if (totalMin <= 9)
        {
            string ttMin = '0' + totalMin.ToString();
            attribute.Value = ttMin;
        }
        else
        {
            attribute.Value = totalMin.ToString();
        }
        userNode.Attributes.Append(attribute);
        node.AppendChild(userNode);



        XmlAttribute attribute2 = xmlDoc.CreateAttribute("milli");
        attribute2.Value = totalMilliSeconds.ToString();
        userNode.Attributes.Append(attribute2);
        node.AppendChild(userNode);


        XmlAttribute attribute3 = xmlDoc.CreateAttribute("thousend");
        attribute3.Value = totalThousendSeconds.ToString();
        userNode.Attributes.Append(attribute3);

        userNode = xmlDoc.CreateElement("lap1");

        attribute = xmlDoc.CreateAttribute("min");
        if (MinCount <= 9)
        {
            string ttMin = '0' + MinCount.ToString();
            attribute.Value = ttMin;
        }
        else
        {
            attribute.Value = MinCount.ToString();
        }
        userNode.Attributes.Append(attribute);
        node.AppendChild(userNode);



        attribute1 = xmlDoc.CreateAttribute("sec");
        attribute1.Value = SecCount.ToString();
        userNode.Attributes.Append(attribute1);
        node.AppendChild(userNode);


        attribute2 = xmlDoc.CreateAttribute("milli");
        attribute2.Value = MilliCount.ToString();
        userNode.Attributes.Append(attribute2);
        node.AppendChild(userNode);


        attribute3 = xmlDoc.CreateAttribute("thousend");
        attribute3.Value = ThousCount.ToString();
        userNode.Attributes.Append(attribute3);

        userNode = xmlDoc.CreateElement("lap2");

        attribute = xmlDoc.CreateAttribute("min");
        if (MinCount2 <= 9)
        {
            string ttMin = '0' + MinCount2.ToString();
            attribute.Value = ttMin;
        }
        else
        {
            attribute.Value = MinCount2.ToString();
        }
        userNode.Attributes.Append(attribute);
        node.AppendChild(userNode);



        attribute1 = xmlDoc.CreateAttribute("sec");
        attribute1.Value = SecCount2.ToString();
        userNode.Attributes.Append(attribute1);
        node.AppendChild(userNode);


        attribute2 = xmlDoc.CreateAttribute("milli");
        attribute2.Value = MilliCount2.ToString();
        userNode.Attributes.Append(attribute2);
        node.AppendChild(userNode);


        attribute3 = xmlDoc.CreateAttribute("thousend");
        attribute3.Value = ThousCount2.ToString();
        userNode.Attributes.Append(attribute3);

        userNode = xmlDoc.CreateElement("lap3");

        attribute = xmlDoc.CreateAttribute("min");
        if (MinCount3 <= 9)
        {
            string ttMin = '0' + MinCount3.ToString();
            attribute.Value = ttMin;
        }
        else
        {
            attribute.Value = MinCount3.ToString();
        }
        userNode.Attributes.Append(attribute);
        node.AppendChild(userNode);



        attribute1 = xmlDoc.CreateAttribute("sec");
        attribute1.Value = SecCount3.ToString();
        userNode.Attributes.Append(attribute1);
        node.AppendChild(userNode);


        attribute2 = xmlDoc.CreateAttribute("milli");
        attribute2.Value = MilliCount3.ToString();
        userNode.Attributes.Append(attribute2);
        node.AppendChild(userNode);


        attribute3 = xmlDoc.CreateAttribute("thousend");
        attribute3.Value = ThousCount3.ToString();
        userNode.Attributes.Append(attribute3);

        node.AppendChild(userNode);
        node.AppendChild(userNode);
        node.AppendChild(userNode);
        node.AppendChild(userNode);
        xmlDoc.DocumentElement.AppendChild(node);
        xmlDoc.Save("racegame.xml");
    }

}

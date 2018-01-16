using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Xml;
using System;
public class LadTime : MonoBehaviour {

    public GameObject time;
    public Text lap1;
    public Text lap2;
    public Text lap3;

    
    string lap1Min;
    string lap1Sec;
    string lap1Milli;
    string lap1Thous;

    string lap2Min;
    string lap2Sec;
    string lap2Milli;
    string lap2Thous;

    string lap3Min;
    string lap3Sec;
    string lap3Milli;
    string lap3Thous;
    // Use this for initialization
    void Start () {
        getLapsTime();
        getLap1Time();
        getLap2Time();
        getLap3Time();
        checkFastestLap();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void getLapsTime()
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load("racegame.xml");
        XmlNodeList userNodes = xmlDoc.SelectNodes("//trial/time");
        foreach (XmlNode userNode in userNodes)
        {
            string min = userNode.Attributes["min"].Value;
            string sec = userNode.Attributes["sec"].Value;
            string milli = userNode.Attributes["milli"].Value;
            string thousend = userNode.Attributes["thousend"].Value;

            time.GetComponent<Text>().text = min + ':' + sec + ':' + milli + '.' + thousend;
            
            xmlDoc.Save("racegame.xml");
        }
    }
    public void getLap1Time()
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load("racegame.xml");
        XmlNodeList userNodes = xmlDoc.SelectNodes("//trial/lap1");
        foreach (XmlNode userNode in userNodes)
        {
            lap1Min = userNode.Attributes["min"].Value;
            lap1Sec = userNode.Attributes["sec"].Value;
            lap1Milli = userNode.Attributes["milli"].Value;
            lap1Thous = userNode.Attributes["thousend"].Value;

            
            xmlDoc.Save("racegame.xml");
        }
    }
    public void getLap2Time()
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load("racegame.xml");
        XmlNodeList userNodes = xmlDoc.SelectNodes("//trial/lap2");
        foreach (XmlNode userNode in userNodes)
        {
            
            lap2Min = userNode.Attributes["min"].Value;
            lap2Sec = userNode.Attributes["sec"].Value;
            lap2Milli = userNode.Attributes["milli"].Value;
            lap2Thous = userNode.Attributes["thousend"].Value;
            
            xmlDoc.Save("racegame.xml");
        }
    }
    public void getLap3Time()
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load("racegame.xml");
        XmlNodeList userNodes = xmlDoc.SelectNodes("//trial/lap3");
        foreach (XmlNode userNode in userNodes)
        {
            lap3Min = userNode.Attributes["min"].Value;
            lap3Sec = userNode.Attributes["sec"].Value;
            lap3Milli = userNode.Attributes["milli"].Value;
            lap3Thous = userNode.Attributes["thousend"].Value;
       
            xmlDoc.Save("racegame.xml");
        }
    }

    public void checkFastestLap()
    {
        int lap1min = Convert.ToInt32(lap1Min);
        int lap1sec = Convert.ToInt32(lap1Sec);
       
        int lap2min = Convert.ToInt32(lap2Min);
        int lap2sec = Convert.ToInt32(lap2Sec);
        
        int lap3min = Convert.ToInt32(lap3Min);
        int lap3sec = Convert.ToInt32(lap3Sec);
      
        // check if lap 1 is the best lap
        if(lap1min <= lap2min && lap1min <= lap3min)
        {
            if(lap1sec < lap2sec || lap1sec < lap3sec)
            {
                if(lap1sec <= 9)
                {
                    lap1.GetComponent<Text>().text = "" + lap1Min + ":0" + lap1Sec + ":" + lap1Milli  + lap1Thous;
                    lap1.color = Color.white;
                }
                else
                {
                    string lapOneTime = lap1Min + ":" + lap1Sec + ":" + lap1Milli +   lap1Thous;
                    lap1.GetComponent<Text>().text = "" + lapOneTime;
                    lap1.color = Color.white;
                }
            }
            else
            {
                lap1.GetComponent<Text>().text = "" + lap1Min + ":" + lap1Sec + ":" + lap1Milli +  lap1Thous;
            }
        }
        else
        {
            lap1.GetComponent<Text>().text = "" + lap1Min + ":" + lap1Sec + ":" + lap1Milli +  lap1Thous;
        }

        // check if lap 2 is the best lap
        if (lap2min <= lap1min && lap2min <= lap3min)
        {
            if (lap2sec < lap1sec || lap2sec < lap3sec)
            { 
                if(lap2sec <= 9)
                {
                    string lapOneTime = lap2Min + ":0" + lap2Sec + ":" + lap2Milli + lap2Thous;
                    lap2.GetComponent<Text>().text = "" + lapOneTime;
                    lap2.color = Color.white;
                }
                else
                {
                    string lapOneTime = lap2Min + ":" + lap2Sec + ":" + lap2Milli +  lap2Thous;
                    lap2.GetComponent<Text>().text = "" + lapOneTime;
                    lap2.color = Color.white;
                }
            }
            else
            {
                lap2.GetComponent<Text>().text = "" + lap2Min + ":" + lap2Sec + ":" + lap2Milli +  lap2Thous;
            }
        }
        else
        {
            lap2.GetComponent<Text>().text = "" + lap2Min + ":" + lap2Sec + ":" + lap2Milli  +  lap2Thous;
        }

        // check if lap 3 is the best lap
        if (lap3min <= lap2min && lap3min <= lap1min)
        {
            if (lap3sec < lap2sec || lap3sec < lap1sec)
            {
                if (lap3sec <= 9)
                {
                    string lapOneTime = lap3Min + ":0" + lap3Sec + ":" + lap3Milli +  lap3Thous;
                    lap3.GetComponent<Text>().text = "" + lapOneTime;
                    lap3.color = Color.white;
                }
                else
                {
                    string lapOneTime = lap3Min + ":" + lap3Sec + ":" + lap3Milli + lap3Thous;
                    lap3.GetComponent<Text>().text = "" + lapOneTime;
                    lap3.color = Color.white;
                }
                
            }
            else
            {
                lap3.GetComponent<Text>().text = "" + lap3Min + ":" + lap3Sec + ":" + lap3Milli +  lap3Thous;
            }
        }
        else
        {
            lap3.GetComponent<Text>().text = "" + lap3Min + ":" + lap3Sec + ":" + lap3Milli  +  lap3Thous;
        }
    }
}

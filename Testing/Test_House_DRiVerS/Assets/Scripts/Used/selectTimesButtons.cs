using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class selectTimesButtons : MonoBehaviour {

    public Button btn;
	
    public void showTotalTimeStats()
    {
        GameObject text = new GameObject();
        btn.GetComponent<Text>().text = "total time";
    }
	public void nextTimeStats()
    {
        GameObject text = new GameObject();
        text.GetComponent<Text>().text = "best lap";
    }
}

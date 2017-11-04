using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour {

    public static int minuteCount;
    public static int secCount;
    public static float milliCount;
    public static string milliDisplay;

    public GameObject minuteBox;
    public GameObject secBox;
    public GameObject milliBox;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        milliCount += Time.deltaTime * 10;
        milliDisplay = milliCount.ToString("F0");
        milliBox.GetComponent<Text>().text = "" + milliDisplay;

        if (milliCount >= 10)
        {
            milliCount = 0;
            secCount += 1;
        }

        if (secCount <= 9)
        {
            secBox.GetComponent<Text>().text = "0" + secCount + ".";
        }
        else
        {
            secBox.GetComponent<Text>().text = "" + secCount + ".";
        }

        if (secCount >= 60)
        {
            secCount = 0;
            minuteCount += 1;
        }

        if (minuteCount <= 9)
        {
            minuteBox.GetComponent<Text>().text = "0" + minuteCount + ".";
        }
        else
        {
            minuteBox.GetComponent<Text>().text = "" + minuteCount + ".";
        }

    }
}

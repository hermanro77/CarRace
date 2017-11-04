using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour {

    public GameObject LapCompleteTrig;
    public GameObject halfWayTrig;

    public GameObject minuteDisplay;
    public GameObject secDisplay;
    public GameObject MilliDisplay;

    public GameObject LaptimeBox;

    void OnTriggerEnter()
    {
        if (LapTimeManager.secCount <= 9)
        {
            secDisplay.GetComponent<Text>().text = "0" + LapTimeManager.secCount + ".";
        }
        else
        {
            secDisplay.GetComponent<Text>().text = "" + LapTimeManager.secCount + ".";
        }

        if (LapTimeManager.minuteCount <= 9)
        {
            minuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.minuteCount + ".";
        }
        else
        {
            minuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.minuteCount + ".";
        }

        MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.milliCount;

        LapTimeManager.minuteCount = 0;
        LapTimeManager.secCount = 0;
        LapTimeManager.milliCount = 0;

        halfWayTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);

    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

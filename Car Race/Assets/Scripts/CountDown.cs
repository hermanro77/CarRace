using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

    public GameObject countDown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject LapTimer;
    public GameObject CarControls;


   
	// Use this for initialization
	void Start () {
        StartCoroutine(CountStart());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        countDown.GetComponent<Text>().text = "3";
        GetReady.Play();
        countDown.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "2";
        GetReady.Play();
        countDown.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "1";
        GetReady.Play();
        countDown.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        GoAudio.Play();

        LapTimer.SetActive(true);
        CarControls.SetActive(true);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class halfwayTrigger : MonoBehaviour {

    public GameObject halfWayTrig;
    public GameObject lapCompleteTrigger;

    void OnTriggerEnter()
    {
        lapCompleteTrigger.SetActive(true);
        halfWayTrig.SetActive(false);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

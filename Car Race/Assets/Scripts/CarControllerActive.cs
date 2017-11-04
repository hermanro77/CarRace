using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarControllerActive : MonoBehaviour {

    public GameObject anyCarName;

	// Use this for initialization
	void Start () {
        anyCarName.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

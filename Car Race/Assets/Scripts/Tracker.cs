using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour {

    public GameObject TheMarker;
    public GameObject[] markers;
    public int MarkTracker;
	
	void Update () {
        TheMarker.transform.position = markers[MarkTracker].transform.position;
	}

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Dreamcar01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker += 1;
            if (MarkTracker == markers.Length){
                MarkTracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}

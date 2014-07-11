using UnityEngine;
using System.Collections;

public class Center3 : MonoBehaviour {

	// Use this for initialization

	public static int c,c1;
	
	// Use this for initialization
	void Start () {

		c = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay(Collider other) {

		c1 = 1;
		
	}
	
	void OnTriggerExit(Collider other) {

		c1 = 0;
	}
}



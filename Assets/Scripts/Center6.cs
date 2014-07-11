using UnityEngine;
using System.Collections;

public class Center6 : MonoBehaviour {

	// Use this for initialization

	public static int f,f1;
	
	// Use this for initialization
	void Start () {

		f = 0;
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerStay(Collider other) {

		f1 = 1;
		
	}
	
	void OnTriggerExit(Collider other) {

		f1 = 0;
	}
}


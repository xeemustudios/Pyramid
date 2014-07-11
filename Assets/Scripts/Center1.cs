using UnityEngine;
using System.Collections;

public class Center1 : MonoBehaviour {

	public static int a,a1;

	// Use this for initialization
	void Start () {

		a = 0;
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerStay(Collider other) {

		a1 = 1;

	}

	void OnTriggerExit(Collider other) {
	
		a1 = 0;
	}
}

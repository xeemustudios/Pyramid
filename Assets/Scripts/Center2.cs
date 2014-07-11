using UnityEngine;
using System.Collections;

public class Center2 : MonoBehaviour {


	public static int b,b1;
	
	// Use this for initialization
	void Start () {

		b = 0;
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerStay(Collider other) {

		b1 = 1;
		
	}
	
	void OnTriggerExit(Collider other) {

		b1 = 0;
	}
}

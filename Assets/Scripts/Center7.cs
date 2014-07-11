using UnityEngine;
using System.Collections;

public class Center7 : MonoBehaviour {


	public static int g,g1;
	
	// Use this for initialization
	void Start () {

		g = 0;
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerStay(Collider other) {

		
		g1 = 1;
	}
	
	void OnTriggerExit(Collider other) {

		g1 = 0;
	}
}

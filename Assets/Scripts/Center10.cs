using UnityEngine;
using System.Collections;

public class Center10 : MonoBehaviour {


	public static int j,j1;
	
	// Use this for initialization
	void Start () {

		j = 0;
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerStay(Collider other) {

		j1 = 1;
		
	}
	
	void OnTriggerExit(Collider other) {

		j1 = 0;
	}
}

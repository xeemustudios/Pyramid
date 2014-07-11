using UnityEngine;
using System.Collections;

public class Center8_1 : MonoBehaviour {

	// Use this for initialization
	
	public static int h,h1;
	
	// Use this for initialization
	void Start () {
		
		h = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(Collider other) {
		
		h1 = 1;
		
	}
	
	void OnTriggerExit(Collider other) {
		
		h1 = 0;
	}
}


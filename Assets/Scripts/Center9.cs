using UnityEngine;
using System.Collections;

public class Center9 : MonoBehaviour {


	public static int i,i1;
	
	// Use this for initialization
	void Start () {

		i = 0;
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerStay(Collider other) {

		i1 = 1;
		
	}
	
	void OnTriggerExit(Collider other) {

		i1 = 0;
	}
}

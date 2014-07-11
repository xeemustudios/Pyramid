using UnityEngine;
using System.Collections;

public class Center5 : MonoBehaviour {

	private float x,y,x1,y1,x2,y2;
	public static int e,e1;
	
	// Use this for initialization
	void Start () {

		e = 0;
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log (x1 +"&&"+ x2 +"&&" +y1+ "&&"+ y2);
	}
	void OnTriggerStay(Collider other) {

		
		e1 = 1;
	}
	
	void OnTriggerExit(Collider other) {

		e1 = 0;
	}
}

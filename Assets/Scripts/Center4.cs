using UnityEngine;
using System.Collections;

public class Center4 : MonoBehaviour {

	// Use this for initialization
	private float x,y,x1,y1,x2,y2;
	public static int d,d1;
	
	// Use this for initialization
	void Start () {

		d = 0;
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log ("c is "+c);
		//Debug.Log (x1 +"&&"+ x2 +"&&" +y1+ "&&"+ y2);
	}
	void OnTriggerStay(Collider other) {

		
		d1 = 1;
	}
	
	void OnTriggerExit(Collider other) {

		d1 = 0;
	}
}



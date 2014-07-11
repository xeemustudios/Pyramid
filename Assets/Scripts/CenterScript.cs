using UnityEngine;
using System.Collections;

public class CenterScript : MonoBehaviour {
	public GameObject A ;
	float a1,a2,b1,b2;
	static int total ;
	public GUIStyle a;

	void Start () {

		total = 0;
	}
	

	void Update () {
		total = Center1.a1 + Center2.b1 + Center3.c1 + Center4.d1 + Center5.e1 + Center6.f1 + Center7.g1 + Center8_1.h1 + Center9.i1 + Center10.j1;

		Debug.Log (total);
	}
	void OnGUI(){

		//GUI.Label (new Rect (100, 100, 200, 200), total.ToString(),a);
		if (total == 10) {
						GUI.Label (new Rect (Screen.width/2-60f, Screen.height/2, 200, 200), "Good JOB .....You Have Done", a);
				}
	}
}

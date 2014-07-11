using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public GameObject A,D,E,F,G,H,J,I,B,C;

	bool a,b,c,d;
	float timeLimit ; // 10 seconds.
	void Start(){
		timeLimit = 15.0f;
		a = b =  false;
		int m = Random.Range (0,2);
		//Debug.Log (m);
		if (m == 0) {
						c = true;
			           d = false;
				} 
		 if (m == 1) {
			c = false;
			d = true;
		} 
	
		}
	void Update()
	{  

	
		// translate object for 10 seconds.
		if(timeLimit > 1) {
			// Decrease timeLimit.
			timeLimit -= Time.deltaTime;
			// translate backward.
			//Application.loadedLevel("main");

		}
		if (timeLimit < 2 && timeLimit > 1) {
						if (c) {
								a = true;
								b = false;
						}
						if (d) {
								a = false;
								b = true;
						}
				}

		if(a){
			B.rigidbody.AddForce(Vector3.right*20);
			A.rigidbody.AddForce(Vector3.right*20);
			D.rigidbody.AddForce(Vector3.right*20);
			E.rigidbody.AddForce(Vector3.right*20);

					                  }	
		if (b) {
			F.rigidbody.AddForce(Vector3.left*20);
			G.rigidbody.AddForce(Vector3.left*20);
			H.rigidbody.AddForce(Vector3.left*20);
			I.rigidbody.AddForce(Vector3.left*20);
			J.rigidbody.AddForce(Vector3.left*20);

				                            }
		if (timeLimit < 1) {
			Start ();
				}

	}
	

}
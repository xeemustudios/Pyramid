using UnityEngine;
using System.Collections;

public class Timer1 : MonoBehaviour {

	
	float timeLimit = 11.0f; // 10 seconds.
	void Update()
	{
		// translate object for 10 seconds.
		if(timeLimit > 1) {
			// Decrease timeLimit.
			timeLimit -= Time.deltaTime;
			// translate backward.
			//Application.loadedLevel("main");
			Debug.Log(timeLimit);
		}
		if (timeLimit < 1) {
						//Application.LoadLevel ("main1");
				}
		
	}

	
}
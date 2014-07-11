using UnityEngine;
using System.Collections;

public class Camera_move : MonoBehaviour {
	float a;
	float b;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Translate(Vector3.right*5*Time.deltaTime);

				}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Translate(Vector3.left*5*Time.deltaTime);
			
		}
		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.Translate(Vector3.forward*5*Time.deltaTime);
			
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			transform.Translate(Vector3.back*5*Time.deltaTime);
			
		}


	}
}

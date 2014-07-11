using UnityEngine;


using System.Collections;





public class MouseMovement : MonoBehaviour {
	
	
	public float speed = 5.0f; // speed at which we move
	private GameObject theObject;
	
	
	private Vector3 target; // what we hold the target in
	private bool hasTarget = false;
	
	
	
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray, out hit, 1000.0f)) {
				if(hit.rigidbody){
					theObject = hit.rigidbody.gameObject;
					hasTarget = true;
				}
			}
			
		}else if (Input.GetMouseButtonUp(0)) {
			hasTarget = false;    
		}else if (hasTarget){
			MoveTheObject();
		}
	}
	
	void MoveTheObject(){
		RaycastHit hit;
		
		
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		
		if(Physics.Raycast(ray, out hit, 1000.0f)) {
			
			
			
			target = new Vector3(hit.point.x, 1.0f, hit.point.z);
			
			// collect the difference between the target and position
			
			Vector3 diff = target - theObject.transform.position;
			
			// set the direction to the diff's normalized direction
			
			Vector3 dir = diff.normalized;
			
			// set the max move amount
			
			float moveAmount = speed * Time.deltaTime;
			
			// if the max move amount is greater then what we have left,
			//    only use what we have left.
			
			if(diff.magnitude < moveAmount)moveAmount = diff.magnitude;
			
			// translate the move amount
			
			theObject.transform.Translate(dir * moveAmount, Space.World);
		}
	}
}


private var ray : Ray;
private var hit : RaycastHit;
var A : GameObject;
var B : GameObject;
var C : GameObject;
var D : GameObject;
var E : GameObject;
var F : GameObject;
var G : GameObject;
var H : GameObject;
var I : GameObject;
var J : GameObject;
var K : GameObject;
var L : GameObject;
var M : GameObject;
var N : GameObject;

function Update(){

    
		
		if(Input.GetMouseButton(0)){
			 ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if(Physics.Raycast(ray,hit)){ 
			if(hit.collider.gameObject.tag == "A"){
				A.transform.position.x = hit.point.x;
				A.transform.position.y = hit.point.y;
				
				Debug.Log(hit.collider.gameObject.name);
				}
			if(hit.collider.gameObject.tag == "B"){
				B.transform.position.x = hit.point.x;
				B.transform.position.y = hit.point.y;
				Debug.Log(hit.collider.gameObject.name);
				}
			if(hit.collider.gameObject.tag == "C"){
				C.transform.position.x = hit.point.x;
				C.transform.position.y = hit.point.y;
				Debug.Log(hit.collider.gameObject.name);
				}
				if(hit.collider.gameObject.tag == "D"){
				D.transform.position.x = hit.point.x;
				D.transform.position.y = hit.point.y;
				
				Debug.Log(hit.collider.gameObject.name);
				}
				if(hit.collider.gameObject.tag == "E"){
				E.transform.position.x = hit.point.x;
				E.transform.position.y = hit.point.y;
				
				Debug.Log(hit.collider.gameObject.name);
				}
				if(hit.collider.gameObject.tag == "F"){
				F.transform.position.x = hit.point.x;
				F.transform.position.y = hit.point.y;
				
				Debug.Log(hit.collider.gameObject.name);
				}
				if(hit.collider.gameObject.tag == "G"){
				G.transform.position.x = hit.point.x;
				G.transform.position.y = hit.point.y;
				
				Debug.Log(hit.collider.gameObject.name);
				}
				if(hit.collider.gameObject.tag == "H"){
				H.transform.position.x = hit.point.x;
				H.transform.position.y = hit.point.y;
				
				Debug.Log(hit.collider.gameObject.name);
				}
				if(hit.collider.gameObject.tag == "I"){
				I.transform.position.x = hit.point.x;
				I.transform.position.y = hit.point.y;
				
				Debug.Log(hit.collider.gameObject.name);
				}
				if(hit.collider.gameObject.tag == "J"){
				J.transform.position.x = hit.point.x;
				J.transform.position.y = hit.point.y;
				
				Debug.Log(hit.collider.gameObject.name);
				}
				if(hit.collider.gameObject.tag == "K"){
				K.transform.position.x = hit.point.x;
				K.transform.position.y = hit.point.y;
				Debug.Log(hit.collider.gameObject.name);
				}
				if(hit.collider.gameObject.tag == "L"){
				L.transform.position.x = hit.point.x;
				L.transform.position.y = hit.point.y;
				Debug.Log(hit.collider.gameObject.name);
				}
				if(hit.collider.gameObject.tag == "M"){
				M.transform.position.x = hit.point.x;
				M.transform.position.y = hit.point.y;
				Debug.Log(hit.collider.gameObject.name);
				}
				if(hit.collider.gameObject.tag == "N"){
				N.transform.position.x = hit.point.x;
				N.transform.position.y = hit.point.y;
				Debug.Log(hit.collider.gameObject.name);
				}
			}
		}
	
		}
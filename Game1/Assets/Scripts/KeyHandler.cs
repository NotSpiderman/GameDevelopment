using UnityEngine;
using System.Collections;

public class KeyHandler : MonoBehaviour {
	public float force;
	public float speed;
	
	public Vector3 direction;
	public bool isMoving;
	
	void Update(){
		
		if(Input.GetKeyDown(KeyCode.W)){
			direction = Vector3.forward;
			isMoving  = true;
			force = speed * 100;
		}
		else if(Input.GetKeyUp(KeyCode.W)){
			direction = -Vector3.forward;
			force = 0;
		}
		
		if(Input.GetKeyDown(KeyCode.S)){
			direction = -Vector3.forward;
			force = speed * 100;
		}
		else if(Input.GetKeyUp(KeyCode.S)){
			direction = Vector3.forward;
			force = 0;
		}
	}
	
	void FixedUpdate(){
		this.rigidbody.AddForce(direction * force * Time.deltaTime);
	}
//	public float speed;
//	public float jumpHeight;
//	
//	private Vector3 movement;
//	
//	void Start(){
//		movement = new Vector3();
//	}
//	
//	void Update(){
//		float moveHorizontal = Input.GetAxis("Horizontal");
//		float moveVertical   = Input.GetAxis("Vertical");
//		
//		movement.x = moveHorizontal;
//		movement.z = moveVertical;
//		
//		this.transform.position = Vector3.Lerp(this.transform.position, this.transform.position + movement, Time.deltaTime * speed);
//	}
}
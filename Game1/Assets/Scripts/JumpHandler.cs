using UnityEngine;
using System.Collections;

public class JumpHandler : MonoBehaviour {
	private Vector3 movement;
	private float distanceToGround;
	public float jumpSpeed;
	public float jumpHeight;
	
	bool IsGrounded(){
		return Physics.Raycast(this.transform.position, -Vector3.up, distanceToGround + 0.1f);
	}
	
	// Use this for initialization
	void Start () {
		distanceToGround = this.collider.bounds.extents.y;
		movement = new Vector3();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space) && IsGrounded()){
			movement.y = jumpHeight;
		}
		else if(Input.GetKeyUp(KeyCode.Space)){
			movement.y = 0;
		}
		
		if(IsGrounded()){
			this.transform.position = Vector3.Lerp(this.transform.position, this.transform.position + movement, Time.deltaTime * jumpSpeed);
		}
		else{
			this.transform.position = Vector3.Lerp(this.transform.position, this.transform.position + movement - Physics.gravity, Time.deltaTime * jumpSpeed);
		}
	}
}

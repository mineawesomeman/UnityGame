using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class jumpCode : MonoBehaviour {
	//I copied this because I am lazy and the jump code I made was shit
	public Vector3 jump;
	public float jumpForce = 2.0f;

	public bool isGrounded;
	Rigidbody rb;
	void Start(){
		rb = GetComponent<Rigidbody>();
		jump = new Vector3(0.0f, 2.0f, 0.0f);
	}

	void OnCollisionStay()
	{
		isGrounded = true;
	}
	void OnCollisionExit() //I kinda made this myself 
	{
		isGrounded = false;
	}

	//End of what I made myself
	void Update(){
		if (Input.GetAxis ("Jump") != 0 && isGrounded) {

			rb.AddForce(jump * jumpForce, ForceMode.Impulse);
			isGrounded = false;
		}
	}
}
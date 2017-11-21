using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class camTest : MonoBehaviour {

	public float mSpeed;
	public float rSpeed;
	public float maxSpeed;
	public float health;
	public float shootDistance;
	bool grounded;
	Rigidbody rb;
	public GameObject shot;
	public Vector3 shotAdjust;
	public int score;
	public int ammo;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		health = 100;
	}
	
	// Update is called once per frame
	void Update () {
		grounded = GetComponent<jumpCode> ().isGrounded;
		if (Input.GetKey(KeyCode.W)&&grounded) {
			rb.AddRelativeForce (Vector3.forward*mSpeed,ForceMode.Acceleration);
		}
		else if (Input.GetKey(KeyCode.S)&&grounded) {
			rb.AddRelativeForce (Vector3.back*mSpeed,ForceMode.Acceleration);
		}
		else if (grounded) {
			rb.velocity = new Vector3 (0f,0f,0f);
		}
		if (Input.GetKey(KeyCode.A)) {
			transform.Rotate (Time.deltaTime*rSpeed*Vector3.down);
		}
		if (Input.GetKey(KeyCode.D)) {
			transform.Rotate (Time.deltaTime*rSpeed*Vector3.up);
		}
		if (Input.GetKeyDown(KeyCode.E)&&ammo > 0) {
			Instantiate (shot,transform.position+(transform.forward*shootDistance)+shotAdjust,transform.rotation).name = "pew";
			ammo--;
		}

		if (health <= 0) {
			SceneManager.LoadScene (0);
		}
		if (health > 100) {
			health = 100;
		}

	}
	void FixedUpdate()
	{
		if (rb.velocity.magnitude > maxSpeed)
		{
			rb.velocity = rb.velocity.normalized * maxSpeed;
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.name == "Death Box") {
			health = 0;
		}
		if (other.tag == "Shot") {
			health -= 10;
			Destroy (other.gameObject);
		}
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "Enemy") {
			health -= 10;
			collision.gameObject.GetComponent<enemyCode> ().relocate ();
		} else if (collision.gameObject.tag == "Health") {
			health += 10;
			Destroy (collision.gameObject);
		} else if (collision.gameObject.tag == "Ammo") {
			ammo += 20;
			Destroy (collision.gameObject);
		}
	}
}

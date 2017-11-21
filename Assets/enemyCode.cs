using UnityEngine;
using System.Collections;

public class enemyCode : MonoBehaviour {

	public Transform main;
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		main = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>();

		if (main != null) {
			transform.LookAt (main);
			transform.Translate (Vector3.forward * Time.deltaTime * speed);
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Shot") {
			//Debug.Log ("Dead " + other.tag);
			main.GetComponent<camTest>().score ++;
			Destroy (other.gameObject);
			Destroy (this.gameObject);
		} else if (other.name == "Death Box") {
			relocate ();
		}
	}

	public void relocate() {
		transform.position = new Vector3(Random.Range(10.1f, 490.1f), 20, Random.Range(10.1f, 490.1f));
	}
}

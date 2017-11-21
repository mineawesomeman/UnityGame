using UnityEngine;
using System.Collections;

public class gunShot : MonoBehaviour {

	public bool destroy;
	public float gunSpeed;

	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * gunSpeed);
		if (transform.position.x > 600 || transform.position.z > 600 || transform.position.x < -100 || transform.position.z < -100 || destroy) {
			Destroy (this.gameObject);
		}
	}
}

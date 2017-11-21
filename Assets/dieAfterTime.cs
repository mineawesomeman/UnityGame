using UnityEngine;
using System.Collections;

public class dieAfterTime : MonoBehaviour {

	public float timeLeft;

	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0f) {
			Destroy (this.gameObject);
		}
	}
}

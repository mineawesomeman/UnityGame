using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class camSetUp : MonoBehaviour {

	public GameObject obj;
	Camera playerCam;
	Canvas test;

	public void setUp() {
		test = obj.GetComponent<Canvas> ();
		playerCam = GameObject.Find ("Player").GetComponentInChildren<Camera>();
		test.worldCamera = playerCam;
	}
}

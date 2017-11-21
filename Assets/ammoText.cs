using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ammoText : MonoBehaviour {

	GameObject player;

	void Update () {
		player = GameObject.FindGameObjectWithTag ("Player");
		GetComponent<Text> ().text = "Ammo: " + player.GetComponent<camTest> ().ammo;
	}
}

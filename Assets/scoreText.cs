using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreText : MonoBehaviour {

	GameObject player;

	void Update () {
		player = GameObject.FindGameObjectWithTag ("Player");
		GetComponent<Text> ().text = "Score: " + player.GetComponent<camTest> ().score;
	}
}

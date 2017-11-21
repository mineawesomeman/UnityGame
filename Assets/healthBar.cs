using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class healthBar : MonoBehaviour {

	GameObject me;
	GameObject player;
	public GameObject blackBar;
	public float health = 100;
	public float xOff;


	void Start () {
		float aspect = (float)Screen.width / Screen.height;

		Debug.Log (Screen.width + "/" + Screen.height);
		Debug.Log (aspect);

		if (aspect >= 1.7f) {
			Debug.Log ("16:9");
			xOff = 5.75f;
		} else if (aspect >= 1.59) {
			Debug.Log ("16:10");
			xOff = 7.5f;
		} else if (aspect >= 3f/2f) {
			Debug.Log ("3:2");
			xOff = 9;
		} else if (aspect >= 1.3f) {
			Debug.Log ("4:3");
			xOff = 16;
		} else {
			Debug.Log ("5:4");
			xOff = 27;
		}

	}


	void Update () {
		player = GameObject.FindGameObjectWithTag("Player");
		health = player.GetComponent<camTest> ().health;
		GetComponent<RectTransform> ().position = new Vector2 (map(health,0f,100f,Screen.width/xOff,Screen.width/2), transform.position.y);

		GetComponent<RectTransform> ().sizeDelta = new Vector2 (map(health, 0f, 100f, 0f, 892f), 25f);
	}

	float map(float x, float in_min, float in_max, float out_min, float out_max) //I love this map code from ardino... I use it in a lot of shit... But I didn't make it
	{
		return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
	}
}

using UnityEngine;
using System.Collections;

public class startCode : MonoBehaviour {

	public GameObject refe;
	public GameObject canvas;
	public GameObject healthBar;
	GameObject jewsus;

	// Use this for initialization
	void Start () {
		jewsus = Instantiate (refe);
		jewsus.name = "Player";
		canvas.GetComponent<camSetUp> ().setUp ();
		//healthBar.GetComponent<healthBar> ().setUp ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

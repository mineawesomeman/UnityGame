using UnityEngine;
using System.Collections;

public class spawnerCode : MonoBehaviour {

	public GameObject enemy;
	public GameObject health;
	public GameObject ammo;
	public bool spawn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Random.Range(10.1f, 490.1f), 20, Random.Range(10.1f, 490.1f));
		int rand = (int)Random.Range (1f,300f);
		if (spawn) {
			if (rand == 83 || rand == 38 || rand == 138) {
				Instantiate (enemy, transform.position, transform.rotation).name = "Enemy";
			} else if (rand == 174) {
				Instantiate (health, transform.position, transform.rotation).name = "Health Box";
			} else if (rand == 284) {
				Instantiate (ammo, transform.position, transform.rotation).name = "Ammo Box";
			}
		}
	}
}

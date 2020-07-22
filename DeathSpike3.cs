using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathSpike3 : MonoBehaviour {
	private bool hadDied = false;

	// Update is called once per frame
	void Update () {

		if (hadDied == true) {
			Die ();
		} //else if (life == 0) {
		//Die ();
		//}
	}

	//what happens when die is called
	void Die(){

		SceneManager.LoadScene("Alan Miiverse Level 3");
	} 

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log("Player has collided with " + coll.collider.name);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {


	private bool hadDied = false;
	//public int life = 3;

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

		SceneManager.LoadScene("Alan Miiverse Level 2");
	} 

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log("Player has collided with " + coll.collider.name);
		//if (coll.gameObject.tag == "Player") {
		//hadDied = true;
		//	life = life - 1;
		//	Debug.Log("Player lives are " + life ); 
		//	}
	}
}
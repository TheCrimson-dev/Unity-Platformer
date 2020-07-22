using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toEndGAme : MonoBehaviour {

	private bool newLevl = false;

	// Update is called once per frame
	void Update () {
		if (newLevl == true) {
			MoveLevel ();
		}

	}


	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log ("Player has collided with " + coll.collider.name);
		if (coll.gameObject.tag == "Player") {
			newLevl = true;
		}
	}


	void MoveLevel(){
		SceneManager.LoadScene ("Alan Miiverse 2.0 MainMenu 1");	
	}



}

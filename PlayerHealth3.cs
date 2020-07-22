using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth3 : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y <= -119.1) {
			//		Debug.Log ("Player Has Died");
			Die (); 
		} else if (gameObject.tag == "enemy") {
			Die ();	
		}       
	}

	void Die() {
		SceneManager.LoadScene("Alan Miiverse Level 3");

	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLayerHealthDeath : MonoBehaviour {



		// Update is called once per frame
		void Update () {
			if (gameObject.transform.position.y < -70.06) {
				Debug.Log ("Player Has Died");
				Die (); 
			} else if (gameObject.tag == "enemy") {
				Die ();	
			}       
		}

		void Die() {
			SceneManager.LoadScene("Level 5");

		}


	}




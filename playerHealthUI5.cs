using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class playerHealthUI5 : MonoBehaviour {

	public PlayerMove5 playerHealth; 

	Text text; 


	// Use this for initialization
	void Start () {

		text = GetComponent <Text> ();

	}

	// Update is called once per frame
	void Update () {

		text.text =  "" + PlayerMove5.pubLife;

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class playerHealthUI3 : MonoBehaviour {

	public PlayerMove3 playerHealth;

	Text text;



	// Use this for initialization
	void Start () {

		text = GetComponent <Text> ();

	}

	// Update is called once per frame
	void Update () {

		text.text =  "" + PlayerMove3.pubLife;

	}
}

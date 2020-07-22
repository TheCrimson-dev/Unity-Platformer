using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealthUI2 : MonoBehaviour {

	public PlayerMove2 playerHealth;

	Text text;



	// Use this for initialization
	void Start () {

		text = GetComponent <Text> ();

	}

	// Update is called once per frame
	void Update () {

		text.text =  "" + PlayerMove2.pubLife;

	}
}

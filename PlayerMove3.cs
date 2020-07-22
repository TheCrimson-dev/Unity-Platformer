using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove3 : MonoBehaviour {

	public int playerSpeed = 10;
	public bool facingRight = false;
	public int playerJumpingPower = 1250;
	private float moveX;
	public bool isGrounded;
	//private bool lvlComplete = false; 
	public int life = 3; 
	public static int pubLife = 0; 


	// Update is called once per frame
	void Update () {

		pubLife = life; 

		PlayerMove();

		if (life == 0) {

			Die ();

		}

	}


	void PlayerMove() {
		//controls
		moveX = Input.GetAxis("Horizontal");
		if (Input.GetButtonDown("Jump") && isGrounded == true)
		{
			Jump(); //this calls the jumpfunction
		}
		//animiations kinda
		//Player Direction
		if (moveX < 0.0f && facingRight == false)
		{
			FlipPlayer(); //this calls the flip player method.
		}
		else if (moveX > 0.0f && facingRight == true) {
			FlipPlayer();
		}

		//this is the phsyiocs behind the scriptt. 
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);

	}

	void Jump(){
		//Jumping Code
		//  GetComponent<Rigidbody2D>().AddForce (Vector2 * playerJumpingPower);
		GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpingPower);
		isGrounded = false;
	}

	void FlipPlayer()
	{
		facingRight = !facingRight;
		Vector2 localScale = gameObject.transform.localScale;
		localScale.x *= -1;
		transform.localScale = localScale;
	}


	void OnCollisionEnter2D(Collision2D coll) {

		//Debug.Log("Player has collided with " + coll.collider.name);

		if (coll.gameObject.tag == "ground") {

			isGrounded = true; 

		} else if (coll.gameObject.tag == "NextLvl") {

			NextLvl ();

		}else if (coll.gameObject.tag == "Enemy"){

			life = life - 1;
			//Debug.Log ("Player lives are ===  " + life);

		}
	}

	void NextLvl(){
		SceneManager.LoadScene ("Level 4");
	}

	void Die(){
		SceneManager.LoadScene ("Alan Miiverse Level 3");

	}



}





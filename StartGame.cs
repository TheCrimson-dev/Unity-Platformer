using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {



	 public void Naruto (string newGameLvl) { 

		SceneManager.LoadScene(newGameLvl);
	
	}

	public void quitGame(){

		Application.Quit();

	}







}
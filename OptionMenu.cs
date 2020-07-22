using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionMenu : MonoBehaviour {

	public void openOptionsMenu(string options){
	
		SceneManager.LoadScene (options);

	}

	public void quitGame(){
	
		Application.Quit (); //quits the game
	
	}

	public void backToGameLvl1(string lvlOne){

		SceneManager.LoadScene (lvlOne);
	
	} //the way i coded this i can add more code so if need be to go back from lvl 1 to lvl 2 and so on.



	public void chooseGameLevel (string lvlSelect){
	
		SceneManager.LoadScene (lvlSelect);
	
	}//this class chooses what level depending on the text set by the desing team




}//end of class
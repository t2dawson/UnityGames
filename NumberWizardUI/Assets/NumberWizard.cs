using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
	public int maxGuesses = 10;
	public Text guessText;

	void Start () {
		StartGame ();
	}

	public void GuessHigher(){
		min = guess;
		NextGuess ();
	}

	public void GuessLower(){
		max = guess;
		NextGuess ();
	}

	void StartGame(){
		max = 1000;
		min = 1;
		NextGuess ();
}
	void NextGuess(){

		maxGuesses -= 1;
		if (maxGuesses <= 0)
			Application.LoadLevel ("Win");
		else {
			guess = Random.Range (min, max + 1);
			guessText.text = guess.ToString ();
		}
	}
}
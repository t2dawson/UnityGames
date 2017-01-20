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
		max = 1001;
		min = 1;
		guess = 500;
}
	void NextGuess(){
		guess = (min + max) / 2;
		maxGuesses -= 1;
		guessText.text = guess.ToString ();
		if (maxGuesses <= 0)
			Application.LoadLevel ("Win");
	}
}
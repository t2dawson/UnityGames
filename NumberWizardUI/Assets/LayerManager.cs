using UnityEngine;
using System.Collections;

public class LayerManager : MonoBehaviour {

	public void SwitchScene(string name){
		Application.LoadLevel (name);
	}

	public void QuitGame (){

		Application.Quit ();
	}
}
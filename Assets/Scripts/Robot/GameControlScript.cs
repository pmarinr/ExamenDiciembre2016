using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControlScript : MonoBehaviour {
	public Text score_txt;
	int puntos = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void suma_uno(){
		puntos += 1;
		score_txt.text = puntos.ToString ();
	}
}

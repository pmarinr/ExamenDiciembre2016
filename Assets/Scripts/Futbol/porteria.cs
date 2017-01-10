using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class porteria : MonoBehaviour {

	public Text marcador;
	public string nombre = "Rosa";
	int goles = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (goles >= 5) {
			SceneManager.LoadScene ("Nave");
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.transform.name == "balon") {
			goles += 1;
			marcador.text = goles + " " + nombre;
		}
	}
}

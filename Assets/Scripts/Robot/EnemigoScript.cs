using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoScript : MonoBehaviour {
	public GameObject laser;
	public Transform punto_disparo;
	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter2D(Collider2D col){
		if (col.transform.tag == "Player") {
			Instantiate (laser,punto_disparo.position,punto_disparo.rotation);
		}
	}
}

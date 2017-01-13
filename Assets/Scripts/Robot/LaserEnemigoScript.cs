using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserEnemigoScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 2);
	}
	
	void OnCollisionEnter2D(Collision2D col){
		if (col.transform.tag == "Player") {
			Destroy (col.gameObject);
		}
		Destroy (gameObject);
	}
}

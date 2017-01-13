using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour {
	Rigidbody2D rb;
	public float velocidad = 15f;
	GameControlScript gcs;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2(0,velocidad);
		Destroy (gameObject, 2);
		gcs = GameObject.Find ("GameControl").GetComponent<GameControlScript> ();
	}
	
	void OnCollisionEnter2D(Collision2D col){
		if (col.transform.tag == "enemigo") {
			Destroy (col.gameObject);
			gcs.suma_uno ();
		}
		Destroy (gameObject);
	}
}

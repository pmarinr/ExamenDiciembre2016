using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot : MonoBehaviour {
	Rigidbody2D rb;
	SpriteRenderer sprite;
	public float velocidad = 5f;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		sprite = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.velocity = new Vector2 (-velocidad, 0);
			sprite.flipX = true;
		}


		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.velocity = new Vector2 (velocidad,0);
			sprite.flipX = false;
		}
		
	}
}

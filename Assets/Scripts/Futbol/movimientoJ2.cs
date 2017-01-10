using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoJ2 : MonoBehaviour {

	public int velocidad = 10;
	int vertical = 0;
	int horizontal = 0;
	Vector2 v_movimiento;

	Rigidbody2D rb2d;
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.W)) {
			vertical = 1;
		}

		if (Input.GetKeyUp (KeyCode.W)) {
			vertical = 0;
		}

		if (Input.GetKeyDown (KeyCode.S)) {
			vertical = -1;
		}

		if (Input.GetKeyUp (KeyCode.S)) {
			vertical = 0;
		}

		if (Input.GetKeyDown (KeyCode.A)) {
			horizontal = -1;
		}

		if (Input.GetKeyUp (KeyCode.A)) {
			horizontal = 0;
		}

		if (Input.GetKeyDown (KeyCode.D)) {
			horizontal = 1;
		}

		if (Input.GetKeyUp (KeyCode.D)) {
			horizontal = 0;
		}

		rb2d.velocity = new Vector2(horizontal,vertical) * velocidad ;

	}
}

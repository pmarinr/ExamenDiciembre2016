using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoJ1 : MonoBehaviour {

	public int velocidad = 10;
	int vertical = 0;
	int horizontal = 0;
	Vector2 v_movimiento;

	Rigidbody2D rb2d;
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			vertical = 1;
		}

		if (Input.GetKeyUp (KeyCode.UpArrow)) {
			vertical = 0;
		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			vertical = -1;
		}

		if (Input.GetKeyUp (KeyCode.DownArrow)) {
			vertical = 0;
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			horizontal = -1;
		}

		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			horizontal = 0;
		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			horizontal = 1;
		}

		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			horizontal = 0;
		}

		rb2d.velocity = new Vector2(horizontal,vertical) * velocidad ;

	}
}

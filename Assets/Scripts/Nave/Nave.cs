using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Nave : MonoBehaviour {

	public float impulso = 100f;
	public float rotacion = 5f;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space)){

			rb.AddForce(transform.up * 100f);
		}

		if(Input.GetKey(KeyCode.RightArrow)){

			rb.AddTorque (-rotacion); // comentario
		}

		if(Input.GetKey(KeyCode.LeftArrow)){

			rb.AddTorque (rotacion);
		}
	}

	public void Reiniciar(){
		SceneManager.LoadScene ("Nave");
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.transform.name == "base2") {
			SceneManager.LoadScene ("Futbol");
		}
	}
}

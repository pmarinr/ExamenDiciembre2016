using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class explota : MonoBehaviour {
	public GameObject explosion;
	public Animator anim_menu;
	

	void OnCollisionEnter2D(Collision2D col){
		Instantiate (explosion, transform.position, transform.rotation);
		anim_menu.SetBool ("menu", true);
		Destroy (gameObject);
	}
		
}

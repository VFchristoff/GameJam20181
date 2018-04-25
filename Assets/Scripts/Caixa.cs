using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caixa : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionStay2D (Collision2D collider) {
		if (collider.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Space)) {
			Destroy (this.gameObject);
		}
	}
}

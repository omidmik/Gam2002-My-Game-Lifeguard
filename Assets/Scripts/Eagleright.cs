using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eagleright : MonoBehaviour {

	private bool startmove = false;
	public float speed = 3;

	// Use this for initialization
	void Start () {

	}

	void Update(){
		if (startmove == true) {
			transform.Translate (Vector2.right * speed * Time.deltaTime);

		}
	}

	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) {

		if (other.gameObject.tag == "Player") {
			startmove = true;


		}

	}
}

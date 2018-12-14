using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public float enemySpeed;

	Animator enemyAnimator;


	public GameObject enemyGraphic;
	bool canFlip = true;
	bool facingRight = false;
	float flipTime = 5f;
	float nextFlipChance = 0f;


	public float chargeTime; 
	float startChargeTime;
	bool charging;
	Rigidbody2D enemyRB;



	// Use this for initialization
	void Start () {
		enemyAnimator = GetComponentInChildren<Animator> ();
		enemyRB = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > nextFlipChance) { 
			if (Random.Range (0, 10) >= 5)
				flipFacing ();
			nextFlipChance = Time.time + flipTime;

		}
	}

	void OnTriggerEnter2D(Collider2D other) {

		if (other.tag == "Player") {
			if (facingRight && other.transform.position.x < transform.position.x) {
				flipFacing ();
			} else if (!facingRight && other.transform.position.x > transform.position.x) {
				flipFacing ();
			} 
			canFlip = false; 
			charging = true;
			startChargeTime = Time.time + chargeTime;


		}
	}
		
	void OnTriggerStay2D(Collider2D other) {
		if (other.tag == "Player") {
			if (startChargeTime < Time.time) {
				if (!facingRight)
					enemyRB.AddForce (new Vector2 (-1, 0) * enemySpeed);
				else enemyRB.AddForce (new Vector2 (1, 0) * enemySpeed);
				enemyAnimator.SetBool ("isCharging", charging);

			}



		}


	}

	void OnTriggerExit2D(Collider2D other) {

		if (other.tag == "Player") {
			canFlip = true;
			charging = false;
			enemyRB.velocity = new Vector2 (0f, 0f);
			enemyAnimator.SetBool ("isCharging", charging);

		}


	}



	void flipFacing(){  

		if (!canFlip)
			return;
		float facingX = enemyGraphic.transform.localScale.x;
		facingX *= -1f;
			enemyGraphic.transform.localScale = new Vector3 (facingX, enemyGraphic.transform.localScale.y, enemyGraphic.transform.localScale.z);

		facingRight = ! facingRight;
	}



}

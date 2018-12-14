using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisTance : MonoBehaviour {

	public float speed;
	public float stoppingDistance;

	private Transform target;


	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("DisBlock").GetComponent<Transform> ();
	}

	// Update is called once per frame
	void Update () {

		if (Vector2.Distance (transform.position, target.position) > stoppingDistance) {
			transform.position = Vector2.MoveTowards (transform.position, target.position, speed * Time.deltaTime);
		}

	}
}

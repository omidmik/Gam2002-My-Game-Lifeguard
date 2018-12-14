using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {
    public GameObject player;
    public float jumppower;
    public GameObject ifactivejump;
        public Rigidbody2D playerrb;
    public bool canjump;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (ifactivejump.active)
        {
            canjump = true;
            if (canjump)
            {

                playerrb.AddForce(Vector2.up * jumppower);
                canjump = false;

            }
            ifactivejump.SetActive(false);
            }
	}
}

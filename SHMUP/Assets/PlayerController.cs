using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	// Update is called once per frame
	private Rigidbody rb;
	public float speed = 5f;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	void Update () {
		if(Input.GetKey("right")) {
			rb.AddForce(Vector3.right * speed);
		} else if (Input.GetKey("left")) {
			rb.AddForce(Vector3.left * speed);
		}

		if(Input.GetKey("up")) {
			rb.AddForce(Vector3.forward * speed);
		} else if (Input.GetKey("down")) {
			rb.AddForce(Vector3.back * speed);
		}
	}
}

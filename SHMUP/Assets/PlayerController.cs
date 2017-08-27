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
			if(transform.position.x >= 90) {
				rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
			} else {
				rb.AddForce(Vector3.right * speed);
			}
		} else if (Input.GetKey("left")) {
			if(transform.position.x <= -90) {
				rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
			} else {
				rb.AddForce(Vector3.left * speed);
			}
		}

		if(Input.GetKey("up")) {
			rb.AddForce(Vector3.forward * speed);
		} else if (Input.GetKey("down")) {
			rb.AddForce(Vector3.back * speed);
		}
	}
}

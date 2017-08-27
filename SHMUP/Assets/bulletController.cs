using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour {
	private Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	void OnCollisionEnter(Collision coll) {
		if(coll.collider.tag == "wall") {
			Destroy(gameObject);
		} else if (coll.collider.tag == "enemy" || coll.collider.tag == "player") {
			Health hp = coll.collider.GetComponent<Health>();
			hp.Hit();
			Destroy(gameObject);
		} else if (coll.collider.tag == "ball") {
			rb.velocity = Vector3.Reflect(rb.velocity, Vector3.back);
		}
	}
}

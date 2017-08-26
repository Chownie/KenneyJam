using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour {
	void OnCollisionEnter(Collision coll) {
		if(coll.collider.tag == "wall") {
			Destroy(gameObject);
		} else if (coll.collider.tag == "ball") {
			
		}
	}
}

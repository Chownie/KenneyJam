using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileLaunch : MonoBehaviour {

	public GameObject projectile;
		
	void Start() {
		spawnMissile();
	}

	void spawnMissile(){
		InvokeRepeating("launchMissile", 2.0f, 1f);
	}

	void launchMissile() {
		Rigidbody instance = Instantiate(projectile, new Vector3(transform.position.x, transform.position.y + 6, transform.position.z), Quaternion.identity).GetComponent<Rigidbody>();
		instance.AddForce(transform.forward * 5000);
	}
}
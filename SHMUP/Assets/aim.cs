using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aim : MonoBehaviour{
	public Transform Player;
	public GameObject projectile;
	public int firingSpeed = 5000;
	public float firingRate = 5f;
	public float firingDelay = 2f;
	public bool Active = false;

	void Update(){
		if(Active && Player != null) {
			transform.LookAt(Player.position);
			transform.eulerAngles = new Vector3(0,transform.eulerAngles.y,0);
		}
	}

	void OnCollisionEnter(Collision coll) {
		if(coll.collider.tag == "wall") {
			Active = !Active;
			if(Active) {
				InvokeRepeating("launchMissile", firingDelay, 1f/firingRate);
			} else {
				CancelInvoke();
			}
		}
	}

	void launchMissile() {
		Vector3 spawnLocation = transform.position + (Vector3.forward*5);
		Rigidbody instance = Instantiate(projectile, new Vector3(spawnLocation.x, spawnLocation.y + 6, spawnLocation.z), Quaternion.identity).GetComponent<Rigidbody>();
		instance.AddForce(transform.forward * firingSpeed);
	}
}
	
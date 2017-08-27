using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {
	public Transform view;
	public RectTransform background;
	public float speed = 1.0f;

	void Start () {
		InvokeRepeating("MoveOnward", 1f, 0.02f);
	}
	
	void MoveOnward() {
		if(view.position.z >= 1600) {
			CancelInvoke("MoveOnward");
		}
		view.position += Vector3.forward * speed;
		background.position += Vector3.back * speed;
	}
}

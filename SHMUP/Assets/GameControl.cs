using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {
	public Transform view;
	public RectTransform background;

	void Start () {
		InvokeRepeating("MoveOnward", 1f, 0.1f);
	}
	
	void MoveOnward() {
		view.position += Vector3.forward;
		background.position += Vector3.back;
	}
}

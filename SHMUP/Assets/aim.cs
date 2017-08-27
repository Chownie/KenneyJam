using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aim : MonoBehaviour{

	public Transform Player;

	void Update(){
		transform.LookAt(new Vector3(Player.position.x, 0, Player.position.z));
	}
}
	
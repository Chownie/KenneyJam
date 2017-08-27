using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
	[SerializeField]
	private int health;

	public void Hit() {
		health -= 1;
		if(health <= 0) {
			var exp = GetComponent<ParticleSystem>();
			exp.Play();
			Destroy(gameObject, exp.main.duration);
		}
	}
}

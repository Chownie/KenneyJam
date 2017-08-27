using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile_spawn : MonoBehaviour {
    public GameObject projectile;
    void Start() {
        spawnMissile();
    }

    void spawnMissile(){
        InvokeRepeating("launchMissile", 2.0f, 0.3f);
    }

    void launchMissile() {
        Rigidbody instance = Instantiate(projectile, new Vector3(transform.position.x, transform.position.y + 5, transform.position.z), Quaternion.identity).GetComponent<Rigidbody>();
        instance.AddForce(transform.forward * 5);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionTest : MonoBehaviour {

	// Grenade explodes after a time delay.
	public float fuseTime;

	void Start() {
		Invoke("Explode", fuseTime);
	}

	// Grenade explodes on impact.
	void OnCollisionEnter(Collision coll) {
		Explode();
	}

	void Explode() {
		var exp = GetComponent<ParticleSystem>();
		exp.Play();
		Destroy(gameObject, exp.duration);
	}
}

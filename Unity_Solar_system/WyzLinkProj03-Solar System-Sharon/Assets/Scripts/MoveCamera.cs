using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	public Transform earthtransform;
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position - earthtransform.position;
	}

	// Update is called once per frame
	void Update () {
		//transform.position = offset + earthtransform.position;
	}
}

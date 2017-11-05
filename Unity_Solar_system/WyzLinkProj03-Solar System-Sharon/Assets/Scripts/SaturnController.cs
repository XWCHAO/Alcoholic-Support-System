using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaturnController : MonoBehaviour {
	public float radius = 60.0f;
	public float speed = 0.06f;

	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		this.transform.localPosition = GetPosition(Time.time * speed);
	}

	private Vector3 GetPosition(float angle)
	{
		return new Vector3(radius * Mathf.Sin(angle), 0, radius * Mathf.Cos(angle));
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JupiterController : MonoBehaviour {

	public float radius = 156.1f;
	public float speed = 0.0033f;

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

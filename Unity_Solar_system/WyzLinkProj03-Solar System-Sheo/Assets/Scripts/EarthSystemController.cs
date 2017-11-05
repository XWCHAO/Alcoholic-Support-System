using UnityEngine;
using System.Collections;

public class EarthSystemController : MonoBehaviour {

    public float radius = 30.0f;
    public float speed = 0.1f;
    public float selfSpeed = 120.0f;

    private Transform Earth;

	// Use this for initialization
	void Start () {
        Earth = this.transform.Find("Earth");
	}
	
	// Update is called once per frame
	void Update () {
        Earth.Rotate(Vector3.up, Time.deltaTime * selfSpeed);

        this.transform.localPosition = GetPosition(Time.time * speed);
	}

    private Vector3 GetPosition(float angle)
    {
        return new Vector3(radius * Mathf.Sin(angle), 0, radius * Mathf.Cos(angle));
    }
}

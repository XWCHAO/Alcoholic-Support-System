using UnityEngine;
using System.Collections;

public class MoonController : MonoBehaviour {

    public float radius = 3.0f;
    public float speed = 0.1f;

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

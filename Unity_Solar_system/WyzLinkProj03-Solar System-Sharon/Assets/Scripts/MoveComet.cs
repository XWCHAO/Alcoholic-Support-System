using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveComet : MonoBehaviour {
    public float moveSpeed = 9f;
    public Transform suntransform;
    public Vector3 dir = Vector3.zero;

    

    // Use this for initialization
    void Start () {
        //if (suntransform)
        //{
        //    dir = suntransform.position - transform.position;
        //    dir = dir.normalized;
        //}
        
    }

    // Update is called once per frame
    void Update () {
        //transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f,            moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);

        transform.LookAt(suntransform.position);
        transform.Translate(Vector3.forward);

        //transform.Translate(dir * Time.deltaTime * moveSpeed);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float radius = 1.5f;
    float speed = 200;
    float x;
    //float yOffSet = 1.2f;
    float angle = 0;
    public int  muki= -1;
    private Rigidbody rb;
    private Vector3 syoki;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        syoki = rb.position;
        x = syoki.x;
        //Debug.Log(syoki);
    }

    void Update()
    {
        angle += muki*speed*Time.deltaTime;

        float y = radius * Mathf.Sin(-angle * Mathf.Deg2Rad)+syoki.y;
        float z = radius * Mathf.Cos(angle * Mathf.Deg2Rad)+syoki.z;
        //transform.localPosition = new Vector3(x, y, z);
        rb.MovePosition (  new Vector3(x, y,z));
       
    }

}
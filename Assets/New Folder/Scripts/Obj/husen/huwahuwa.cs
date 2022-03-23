using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class huwahuwa : MonoBehaviour
{
    private Rigidbody rb;
    public float huwaForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.up*huwaForce*Time.deltaTime);
    }
}

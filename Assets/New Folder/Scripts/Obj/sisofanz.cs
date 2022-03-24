using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sisofanz : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 torque;//= new Vector3(1, 0, 0);
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.AddRelativeTorque(torque,ForceMode.VelocityChange);
     //   rb.AddForceAtPosition(torque,transform.localPosition + 3*Vector3.right,ForceMode.Impulse);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
       // for(int i = 0; i < collision.contacts.Length; i++) { 
        FanzManager following = collision.gameObject.GetComponent<FanzManager>();
        if (following == null) return;// break;

        //rb.AddForceAtPosition(torque, collision.contacts[0].point, ForceMode.Force);
        //  rb.AddForceAtPosition(-torque, -collision.contacts[0].point, ForceMode.Impulse);
        Vector3 tex = collision.contacts[0].point - transform.position;
        if (tex.z > 0)
        {
            rb.AddTorque(torque,ForceMode.Impulse);
        }else
        {
            rb.AddTorque(-torque, ForceMode.Impulse);
        }
        //Debug.Log(collision.contacts[0].point-transform.position);
    }
    private void Update()
    {
//        rb.AddTorque(torque);
    }
    //    Vector3 acceleration;
    //    Vector3 velocity;
    //    Vector3 position;
    //    const float dt = 1f / 60f;
    //    float gravity = 9.8f;
    //    float mass = 10.0f;
    //    // Start is called before the first frame update
    //    void Start()
    //    {
    //        position = transform.position;
    //        acceleration += -gravity * mass * Vector3.up;
    //    }

    //    // Update is called once per frame
    //    void FixedUpdate()
    //    {
    //        velocity += acceleration * dt;
    //        position += velocity * dt;
    //        transform.position = position;
    //        acceleration = Vector3.zero;
    //    }
    //
}

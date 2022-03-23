using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Following : MonoBehaviour
{
    public Transform target;
    public float minKyori = 0.5f;
    FanzManager manager;
    public float maxSpeed = 6f;


    Rigidbody rb;
    Vector3 moveV;
    private Vector3 vec = new Vector3(1, 0, 1);
    // Vector3 moveDirection = new Vector3(0, 0, -1);//向いている方向に進む
    Animator anim;
    private void Start()
    {
        manager = GetComponent<FanzManager>();
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        LookRotate();
        if (!manager.isFollowing) return;

         moveV = MoveVelocity();
        
        //Debug.Log(moveV);
        rb.velocity=(moveV);
        

    }
    void LookRotate()
    {
        Vector3 lengthV = target.transform.position - this.transform.position;

        transform.rotation = Quaternion.LookRotation(Vector3.Scale(lengthV, vec));
    }
    private Vector3 MoveVelocity()
    {
       
    Vector3 lengthV =  target.transform.position - this.transform.position;
        float length = lengthV.magnitude-minKyori;
        
        transform.rotation = Quaternion.LookRotation(Vector3.Scale(lengthV, vec));
        float speed = Mathf.Clamp(length, -maxSpeed, maxSpeed);
        anim.SetFloat("Speed", speed);
        lengthV.Normalize();
        return lengthV*speed;
            
    }
}

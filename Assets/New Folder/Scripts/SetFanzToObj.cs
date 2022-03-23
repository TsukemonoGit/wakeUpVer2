using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFanzToObj : MonoBehaviour
{
    public Transform constraint;
    public bool isConstraint;
    Rigidbody rb;
    public CapsuleCollider capsule;
    public BoxCollider box;
    bool isStop = false;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        Constraint();
    }
    void Constraint()
    {
        GetComponent<Following>().enabled = false;
        isConstraint = true;
        rb.isKinematic = true;
        capsule.enabled = false;
        box.enabled = false;
       transform.position = constraint.position;
        
       
    }
    private void Update()
    {
        if (isConstraint)
        {
            transform.position = constraint.position;
            transform.rotation = constraint.rotation;
        }
        else if( !isStop)
        {
            isStop = true;
            StopConstraint();

        }
        else
        {
            this.enabled = (false);
        }
    }
    void StopConstraint()
    {
        transform.rotation = Quaternion.identity;
        rb.isKinematic = false;
        capsule.enabled =true;
        box.enabled = true;
        GetComponent<Following>().enabled = true;

    }

}

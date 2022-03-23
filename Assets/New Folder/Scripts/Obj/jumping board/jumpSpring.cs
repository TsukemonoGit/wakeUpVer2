using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpSpring : MonoBehaviour
{
    public float force;
    private void OnCollisionEnter(Collision collision)
    {
Rigidbody rb=        collision.gameObject.GetComponent<Rigidbody>();
        if (rb != null) { rb.AddForce(Vector3.up * force, ForceMode.Impulse); }
    }
}

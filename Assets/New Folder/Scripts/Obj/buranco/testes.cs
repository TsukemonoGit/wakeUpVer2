using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testes : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 force = new Vector3(1, 0, 0);
    public float forcef = 10f;
    public bool addForce = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // rb.AddForce(force,ForceMode.Impulse);
    }
    [ContextMenu("Add")]
    public void RBAddForce()
    {
        rb.AddForce(force, ForceMode.Impulse);

    }

    private void FixedUpdate()
    {
        if (addForce)
        {
            AddForce();
        }
    }
    void AddForce()
    {
        rb.AddForce(forcef * transform.forward * Time.deltaTime);//,ForceMode.Impulse);

    }
    public void OnClickButton() {
        addForce = true;
    }
    public void PointerUp()
    {
        addForce = false;
    }



}

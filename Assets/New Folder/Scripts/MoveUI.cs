using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUI : MonoBehaviour
{
    public Transform constraint;
    public Vector3 offset;
    new Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        camera=GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = camera.WorldToScreenPoint(constraint.position +offset); 
      
        //  transform.position = constraint.position + offset;
    }

}

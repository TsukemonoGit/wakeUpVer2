using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubCameraCon : MonoBehaviour
{
    Quaternion defo;

    // Start is called before the first frame update
    void Start()
    {
        defo = transform.rotation;


    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = defo;   
    }
    public void SetSubCamera(bool set)
    {
        this.gameObject.SetActive(set);
    }
   
   
}

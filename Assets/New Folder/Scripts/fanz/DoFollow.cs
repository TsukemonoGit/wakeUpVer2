using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoFollow : MonoBehaviour
{
    //private Following follow;
    private FanzManager fanzManager;
    public float wariai = 0.4f;
  

    private void Start()
    {
        //follow = transform.parent.GetComponent<Following>();
        fanzManager = transform.parent.GetComponent<FanzManager>();
        if (fanzManager == null){
            Debug.Log("fanzController見つかってないよ");
        }
    }
    
    void OnTriggerEnter(Collider collision)
    {

        CharacterController player = collision.gameObject.GetComponent<CharacterController>();
        if (player != null)
        {
            //fanzCon.
            fanzManager.inTrigger = true;
         //   follow.wariai = wariai;
           // follow.enabled = true;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        CharacterController player = other.gameObject.GetComponent<CharacterController>();
        if (player != null)
        {
            //fanzCon.
            fanzManager.inTrigger = false;
        }
    }
    
}


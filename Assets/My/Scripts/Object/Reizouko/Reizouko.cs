using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reizouko : MonoBehaviour
{
    public kuuhukuQuest quest;
    public Animator anim1;
    public Animator anim2;
   // public bool inTrigger;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        CharacterController controller = other.GetComponent<CharacterController>();
        if (controller != null && quest.cook==CookState.Questing)
        {
            anim1.SetBool("Open", true);
            anim2.SetBool("Open", true);
            anim1.SetBool("Close", false);
            anim2.SetBool("Close", false);
            //          inTrigger = true;   
        }
    }
    private void OnTriggerExit(Collider other)
    {
        CharacterController controller = other.GetComponent<CharacterController>();
        if (controller != null && quest.cook==CookState.Questing)
        {
            //         inTrigger = false;
            anim1.SetBool("Close", true);
            anim2.SetBool("Close", true);
            anim1.SetBool("Open", false);
            anim2.SetBool("Open", false);
        }
    }

}

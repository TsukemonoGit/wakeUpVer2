using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reizouko : MonoBehaviour
{
    public kuuhukuQuest quest;
    public Animator anim1;
    public Animator anim2;
//    public GameObject omuraisu;
    public Transform omuParent;
  public bool inTrigger;
    public bool isOpen;
    public ClickObj[] objs;
    public ClickObj nowSelect;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        CharacterController controller = other.GetComponent<CharacterController>();
        if (controller != null && quest.cook!=CookState.Idle)
        {
            isOpen = true;
            anim1.SetBool("Open", true);
            anim2.SetBool("Open", true);
            anim1.SetBool("Close", false);
            anim2.SetBool("Close", false);
          //     inTrigger = true;   
        }
    }
    private void OnTriggerExit(Collider other)
    {
        CharacterController controller = other.GetComponent<CharacterController>();
        if (controller != null && anim1.GetBool("Open"))
        {
            isOpen = false;
       //             inTrigger = false;
            anim1.SetBool("Close", true);
            anim2.SetBool("Close", true);
            anim1.SetBool("Open", false);
            anim2.SetBool("Open", false);
        }
    }
    //public void PointerClick()
    //{
    //    if (anim1.GetBool("Open"))
    //    {
    //        //Debug.Log("GetOmu");
    //        omuraisu.transform.parent = omuParent;
    //        omuraisu.transform.localPosition = Vector3.zero;
    //        quest.cook = CookState.QuestClear;
    //    }
    //}
    private void Update()
    {
       if(quest.GetComponent<FanzController>().isMisshionClear &&anim1.GetBool("Close"))
        {
        //    Debug.Log("ters");
            nowSelect.gameObject.SetActive(false);
            this.enabled=(false);
        } 
    }
}

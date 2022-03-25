using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObj : MonoBehaviour
{
    public Reizouko reizouko;
    GameObject obj;
    public CookState changeState;
   Vector3 syokiPos;
    Transform syokiParent;
    private void Start()
    {
        syokiPos = transform.position;
        syokiParent = transform.parent;
        obj = this.gameObject;
    }
    public void PointerClick()
    {
        if (reizouko.isOpen)
        {
            //Debug.Log("GetOmu");
            if (reizouko.nowSelect != null)
            {
                reizouko.nowSelect.SetSyokiPos();
            }
            obj.transform.parent = reizouko.omuParent;
            obj.transform.localPosition = Vector3.zero;
            reizouko.nowSelect = this;
            if (!reizouko.quest.GetComponent<FanzController>().isMisshionClear)
            {
                reizouko.quest.cook = changeState;
            }
        }
    }
    public void SetSyokiPos()
    {
        transform.position = syokiPos;
        transform.parent = syokiParent;
    }
}

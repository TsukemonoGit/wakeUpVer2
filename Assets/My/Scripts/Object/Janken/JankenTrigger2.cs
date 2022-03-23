using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JankenTrigger2 : MonoBehaviour
{
    FanzManager fanManager;
    FanzController fanzCon;
    public bool isActive=false;
    public Janken janken;
    // Start is called before the first frame update
    void Start()
    {
        fanManager = GetComponent<FanzManager>();
        fanzCon = GetComponent<FanzController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (fanManager.inTrigger && !isActive&& !fanzCon.isMisshionClear)
        {
            janken.JankenStart();
            isActive = true;
        
    }else if(!fanManager.inTrigger && isActive )
        {
            isActive = false;
            janken.OnOrari();
        }
    }
}

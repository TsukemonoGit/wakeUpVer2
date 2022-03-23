using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTimeList : MonoBehaviour
{
    
    GameController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<GameController>();
        controller.startTime = SingletonManager.instance.timeList[SingletonManager.instance.timeNum];
    }

    
}

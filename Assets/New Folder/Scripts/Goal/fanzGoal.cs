using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanzGoal : MonoBehaviour
{
    public PosList posList;
    public EnterCheck enter;
    public GameController gameCon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enter.fanzList .Count>0)
        {
            enter.fanzList[0].GetComponent<Following>().maxSpeed = 2f;
            enter.fanzList[0].GetComponent<Following>().target = posList.road.transform;
            gameCon.collected_fanz++;
            enter.fanzList.RemoveAt(0);
            
            
        }    
    }
}

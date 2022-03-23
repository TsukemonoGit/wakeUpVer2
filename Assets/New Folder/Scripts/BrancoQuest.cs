using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrancoQuest : MonoBehaviour
{
    public FanzController fanzCon;
    public Transform point;
    int syokiY;
    public int clearLength = 30;
    bool isClear;
    public UIManager UImanager;
    QuestCanvasController questUI;
     public int max;
    int preCheck;
    public Color colorDefo;
    public Color UIcolor;
    
    // Start is called before the first frame update
    void Start()
    {
        syokiY = Mathf.RoundToInt(point.position.y * 10);
        questUI = UImanager.questUI;
    }

    // Update is called once per frame
    void Update()
    {
        if (!fanzCon.isMisshionClear && !isClear )
        {
            int nowY = Mathf.RoundToInt(point.position.y * 10);

            int checkNum = nowY - syokiY;
            if (checkNum != preCheck)
            {
                questUI.SetSliderValue(checkNum);
            }
            
            max= checkNum > max ? checkNum : max;
            if (max > clearLength * 0.7f)
            {
                 questUI.SetMessage("もっともっと");
               
            }
            if (checkNum > clearLength)
            {
                isClear = true;
                questUI.SetTextColor(UIcolor);
                questUI.SetSliderColor(UIcolor);
                questUI.SetMessage( "ぱーへくち");
                StartCoroutine(Clear());        
             
            }
            preCheck = checkNum;
        }
        
    }
    IEnumerator Clear()
    {
        fanzCon.isMisshionClear = true;
        GetComponent<SetFanzToObj>().isConstraint = false;
        yield return null;
        this.enabled = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class burancoManager : MonoBehaviour
{
public enum State { noriori,osihiki}
    public State state = State.osihiki;
    bool noreru ;
    public testes buranco;
    public string message;
    public string button;
    public int messageFontSize;
    public int buttonFontSize;
    public int buttonNum = 0;
    public Transform constraint;//ui固定

    //UI
    public UIManager UImanager;
    QuestCanvasController questUI;//動く方
    CanvasContoller UIcanvas;//動かない方
                             //
    public BrancoQuest quest;
    ClickBuranco click;
   FanzController fanz;

    private void Awake()
    {

        UIcanvas = UImanager.UICanvas;
        questUI = UImanager.questUI;
        click = GetComponent<ClickBuranco>();
        if (quest != null)
        {
            fanz = quest.gameObject.GetComponent<FanzController>();
            noreru = false;
        }
        else { noreru = true; }
    }

    public void TriggerEnter()
    {
       
        click.check = true;
        string[] text = new string[1] { "おす" };
        UIcanvas.SetCanvas("ぶらんこ", text);
        if (quest != null && !fanz.isMisshionClear)
        {
          

           
            questUI.SetActiveSlider(true);
            quest.enabled = true;
            questUI.SetUIActive(true);
            questUI.SetSliderMax(quest.clearLength);
            questUI.SetConstraint(constraint);
            questUI.SetMessage("まんぞく度");
            questUI.SetSliderColor(quest.colorDefo);
            questUI.SetTextColor(quest.colorDefo);
            questUI.SetSliderValue(quest.max);
        }
       
       //     Debug.Log("enter");
        }


    public void TriggerExit()
    {
        if (questUI != null)
        {
            questUI.SetUIActive(false);
            
        }
        UIcanvas.SetCanvas();
            buranco.addForce = false;//ブランコフォースオフに
                                     //      Debug.Log("Exit");
        click.check = false;
        quest.enabled=(false);
    }
    
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Janken : MonoBehaviour
{
    public enum State { IDLE, START, SELECT, JUDGE, WIN, LOSE, DRAW, END }
    public enum Select { GU, CHO, PA }

    public State state =State.IDLE;
   Select mySelect;
    Select otherSelect;
    public Select preSelect;

public  ViewCanvasControl view;
    SetCanvas set;
    JankenQuest quest;

    //public JanCanManager janCanManager;
    //public JankenQuest quest;
    //public HandController hand;
    //public JankenAnimator playerHand;

    private void Start()
    {

        quest = GetComponent<JankenQuest>();
        if (quest == null){
            Debug.Log("no");
        }
      view = GetComponent<ViewCanvasControl>();
        set = GetComponent<SetCanvas>();
       
       // JankenStart();
    }
    public void JankenStart()
    {
        if (state == State.IDLE)
        {
       
            state = State.START;
            StartPhase();
            quest.ViewQuestUI(true);
        }

    }
   public  void StartPhase()
    {
        quest.enabled = true;   
        //    janCanManager.gameObject.SetActive(true);
        set.check = true;
       view.SetSetCanvas(0);
       // Debug.Log("Start");
       // Debug.Log("じゃんけん");
      //  janCanManager.SetText("じゃんけん");
      //  state = State.SELECT;
       // SelectPhase();
    }
  
    void SelectPhase()
    {
       
        //anim
        ///   hand.PonHand(false);
        //    playerHand.Janken(false);
        //
        //       janCanManager.ViewSelect(true);
        //→OnClick
    }
    IEnumerator  JudgePhase()
    {
      //  janCanManager.ViewSelect(false);
        otherSelect = (Select)Random.Range(0, 3);
        //連続で同じ手が出る確率を減らす
        if (otherSelect == preSelect)
        {
            otherSelect = (Select)Random.Range(0, 3);
        
        }
        //anim
     //   hand.PonHand(true);
   //     playerHand.Janken(true);
   //     hand.SetHandAnim((int)otherSelect);
    //    playerHand.PonHand((int)mySelect);
        //
        preSelect = otherSelect;
        yield return new WaitForSeconds(0.5f);
        //    Debug.Log(otherSelect);
        //string aite;
        //if ((int)otherSelect == 0) aite = "ぐー";
        //else if ((int)otherSelect == 1) aite = "ちょき";
        //else aite = "ぱー";

        //janCanManager.SetText("あいて："+aite);
        int judgeNum = mySelect - otherSelect;

        //あいこ
        if (judgeNum==0)
        {
            state = State.DRAW;
            DrawPhase();
        }
        //勝ち
        else if (judgeNum==-1 || judgeNum == 2) {
            state = State.WIN;
            WinPhase();
        }
        //負け
        else {
            state = State.LOSE;
            LosePhase();
        }
        
    }
    void WinPhase()
    {
        set.check = true;
        view.SetSetCanvas(3);
        //      Debug.Log("かち");
               quest.Victory();
        //      janCanManager.SetText("かった！");
      //  state = State.END;
       //StartCoroutine( EndPhase());
    }
    void LosePhase()
    {
        set.check = true;
        view.SetSetCanvas(4);
          quest.Lose();
        //      Debug.Log("まけ");
        //    janCanManager.SetText("まけちゃった");
     //   state = State.END;
    //    StartCoroutine(EndPhase());
    }
    void DrawPhase()
    {
        set.check = true;
        view.SetSetCanvas(2);
        //      Debug.Log("あいこで");
        //   janCanManager.SetText("あいこで");
        state = State.SELECT;
        SelectPhase();
    } 
    IEnumerator EndPhase()
    {
        view.SetSetCanvas();
       quest.ViewQuestUI(false);
        yield return new WaitForSeconds(0.2f);
       
        //anim
        //    hand.PonHand(false);
        //   playerHand.Janken(false);
        //
        // Debug.Log("おわり");
        //      janCanManager.SetText("おわり");
        //       janCanManager.gameObject.SetActive(false);
      
        state = State.IDLE;
        quest.enabled = false;
    }

    //ButtonClick
    public void OnClickSUTU()
    {
        set.check = true;
        view.SetSetCanvas(1);
        state = State.SELECT;
        SelectPhase();
    }

    public void OnClickGU()
    {
        mySelect = Select.GU;
        state = State.JUDGE;
        StartCoroutine(JudgePhase());
    }
    public void OnClickCHO()
    {
        mySelect = Select.CHO;
        state = State.JUDGE;
        StartCoroutine(JudgePhase());
         }
    public void OnClickPA()
    {
        mySelect = Select.PA;
        state = State.JUDGE;
        StartCoroutine( JudgePhase());
    }
    public void OnMokkai()
    {
        set.check = true;
       view.SetSetCanvas(1);
        state = State.SELECT;
        SelectPhase();
    }
    public void OnOrari()
    {
      
        state = State.END;
        StartCoroutine(EndPhase());

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JankenQuest : MonoBehaviour
{
    
    [Header("クリアライン")]
    public int clearLine=6;
    [Header("負け点")]
    public int maketen=2;
    [Header("勝ち点")]
    public int katiten=-1;
    [Header("今の点数")]
    public int nowten=0;
    [Header("標準色")]
    public Color color;
    [Header("マイナスライン色")]
    public Color color1;
    [Header("勝ち色")]
    public Color color2;

    public GManager gameManager;
    public FanzController fanzCon;
    public UIManager UImanager;
    private QuestCanvasController questUI;
    Janken janken;

    //F押してあったらリセットするため
    public InputManager _input;
    private void Start()
    {
        janken = GetComponent<Janken>();
        questUI = UImanager.questUI;
        if (questUI == null)
        {
            Debug.Log("no");
        }
       // jankenUI.SetActiveSlider(true);
    }
    public void ViewQuestUI(bool value)
    {
        questUI.SetUIActive(value);
        questUI.SetSliderMax(clearLine);
        questUI.SetActiveSlider(value);
        questUI.SetConstraint(fanzCon.constraint);
        questUI.SetMessage("まんぞく度");
        questUI.SetSliderColor(color);
        questUI.SetTextColor(color);
        questUI.SetSliderValue(nowten);
    }
    public void Victory()
    {
        nowten += katiten;
        questUI.SetMessage("めちゅー");
        //jankenUI.LeapSlider(Mathf.Clamp(nowten,0,clearLine+1));
        questUI.SetSliderValue(nowten);
        if (nowten < 0)
        {
            questUI.SetSliderColor(color1);
            questUI.SetTextColor(color1);

        }
       
        Check();
    }
    public void Lose()
    {
     questUI.SetMessage("もっともっと");
        nowten += maketen;
        questUI.SetSliderValue(nowten);
        //   jankenUI.LeapSlider(Mathf.Clamp(nowten, 0, clearLine+1));
        if (nowten>0)
        {
            questUI.SetSliderColor(color);
            questUI.SetTextColor(color);

        }
        Check();
    }
    void Check()
    {
        if (nowten >= clearLine)
        {
            questUI.SetSliderColor(color2);
            questUI.SetTextColor(color2);
          questUI.SetMessage("ぱーへくち");
            
            janken.view.SetSetCanvas();
            StartCoroutine(ClearItem());
            fanzCon.isMisshionClear = true;

        }

    }
  
    IEnumerator ClearItem()
    {
     questUI.SetActiveSlider(false);
        yield return new WaitForSeconds(1f);
  questUI.SetTextColor(Color.white);
  questUI.SetMessage("ふうせん　あげる");
        
        yield return new WaitForSeconds(1f);
     questUI.SetMessage(" Fキーでモード切替\nEキーで上昇\nQキーで下降だよ");
        _input.flyMode = false;//フライモードリセット
        gameManager.CanFly = true;
        yield return new WaitForSeconds(2f);
        janken.OnOrari();
    }


}

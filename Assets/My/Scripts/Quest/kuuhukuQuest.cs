using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//アイテム収集クエスト
//料理クエスト
public enum CookState { Idle,Questing,CollectZairyo,CookingClear,QuestClear}
public class kuuhukuQuest : MonoBehaviour
{
    public CookState cook = CookState.Idle;

    public GManager manager;
    public UIManager ui;
    FanzManager fanz;
    QuestCanvasController queCan;
     CanvasContoller view;

    [Space(10)]
    [Header("動く方のキャンバス")]
    public Transform constraint;
    public int sliderMaxValue;
    public string[] messageQ;
    public Color[] color;
    [Multiline]
    public string[] message2;

    [Space(10)]
    [Header("動かない方のキャンバス")]
    public string[] messageUI;
    public int buttonNum = 1;
    public string[] buttonMessage;//ボタン２個じゃなくて１この２パターン

    bool nowView;

    private void Start()
    {
        queCan = ui.questUI;
        view = ui.UICanvas;
        fanz = GetComponent<FanzManager>();
        for (int i = 0; i < color.Length; i++)
        {
            color[i].a = 1;
        }
    }
    private void Update()
    {
        if (fanz.inTrigger && !nowView)
        {
            nowView = true;
            SetCanvases();
        }else if(!fanz.inTrigger && nowView)
        {
            nowView = false;
            queCan.SetMessage2("");
            CloseCanvases();
            
        }
    }

    void SetCanvases()
    {
       
        switch (cook)
        {
            case CookState.Idle:
                queCan.SetUIActive(true);
                queCan.SetConstraint(constraint);
                queCan.SetSliderMax (sliderMaxValue);
                queCan.SetActiveSlider(true);
                queCan.SetMessage(messageQ[0]);
                queCan.SetMessage2(message2[0]);
                queCan.SetTextColor(color[0]);
                cook = CookState.Questing;
                break;
            case CookState.Questing:
                break;
            case CookState.CollectZairyo:
                break;
            case CookState.CookingClear:
                break;
            case CookState.QuestClear:
                break;

        }
    }
    void CloseCanvases()
    {
        view.SetCanvas();
        queCan.SetUIActive(false);
    }
}

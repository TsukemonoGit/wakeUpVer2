using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//canvasの出力を受ける方につける
//オブジェクトごとに設定するやつ

public class ClickLongBuranco : MonoBehaviour
{
    burancoManager manager;
    public UIManager managerUI;
    public bool check;
    public int returnNumber;
    int clickCount = 0;
    public testes brancoForce;//
    public string[] text1 = new string[1] { "おす" };
    public string[] text2 = new string[1] { "はなす" };
    public string[] text3 = new string[1] { "のる"  };
    public string[] text4 = new string[1] { "おりる" };

    private void Start()
    {
        manager = GetComponent<burancoManager>();
    }

    private void Update()
    {
        if (check && managerUI.UICanvas.selectButton > 0)
        {

            returnNumber = managerUI.UICanvas.selectButton;

            Debug.Log(managerUI.UICanvas.selectButton);
            switch (managerUI.UICanvas.selectButton)
            {
                //-----------------case1
                case 1:
                    if (manager.state == burancoManager.State.osihiki)
                    {
                        if (clickCount == 0)
                        {

                            brancoForce.addForce = true;
                            clickCount = 1;
                            managerUI.UICanvas.SetCanvas("ぶらんこ", text2);
                        }
                        else if (clickCount == 1)
                        {
                            brancoForce.addForce = false;
                            clickCount = 0;
                            managerUI.UICanvas.SetCanvas("ぶらんこ", text1);
                        }
                    }
                    else
                    {
                        managerUI.UICanvas.SetCanvas("ぶらんこ", text3);
                        //のりおりのときのしょり
                    }
                    Debug.Log("1");
                    break;
                //-----------------case2
                case 2:

                    Debug.Log("2");
                    break;
                //-----------------case3
                case 3:

                    Debug.Log("1");
                    break;
                //-----------------case4
                case 4:

                    Debug.Log("2");
                    break;
            }
            managerUI.UICanvas.selectButton = 0;
        }
    }

}

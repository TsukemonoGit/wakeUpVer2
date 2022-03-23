using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//canvasの出力を受ける方につける
public class ClickBuranco : MonoBehaviour
{

    public UIManager managerUI;
    public bool check;
    public int returnNumber;
    int clickCount=0;
    public testes brancoForce;//
    public string[] text1 = new string[1] { "おす" };
    public string[] text2 = new string[1] { "はなす" };
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
                    if (clickCount == 0)
                    {
                        brancoForce.addForce = true;
                        clickCount = 1;
                        managerUI.UICanvas.SetCanvas("ぶらんこ", text2 );
                    }else if (clickCount == 1){
                        brancoForce.addForce = false;
                        clickCount = 0;
                        managerUI.UICanvas.SetCanvas("ぶらんこ", text1);
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

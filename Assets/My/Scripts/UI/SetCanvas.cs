using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//canvasの出力を受ける方につける
public class SetCanvas : MonoBehaviour
{
    Janken janken;
    public UIManager managerUI;
    public string message;
    public int useButton;
    public string[] buttonText;
    public bool check;
    public MessageList list;
    public int returnNumber;

    private void Start()
    {
        janken = GetComponent<Janken>();
       
    }
    //public void SetUICanvas()
    //{
    //    managerUI.UICanvas.SetCanvas(message, useButton);
    //  for (int i = 0; i < useButton; i++){
    //        managerUI.UICanvas.buttons[i].SetMessageText(buttonText[i]);
    //    }
    //}
    public void SetUICanvas()
    {
              managerUI.UICanvas.SetCanvas();
    }
    public void SetUICanvas(MessageList list)
    {
        Debug.Log(list.mainMessage);
        managerUI.UICanvas.SetCanvas(list.mainMessage, list.buttonStrings);
    }
    private void Update()
    {
        if(check  && managerUI.UICanvas.selectButton > 0)
        {
            check = false;
            returnNumber = managerUI.UICanvas.selectButton;
            Debug.Log(managerUI.UICanvas.selectButton);
            switch (managerUI.UICanvas.selectButton)
            {
                //-----------------case1
                case 1:
                    if (janken.state == Janken.State.START)
                    {
                        janken.OnClickSUTU();
                    }
                    else
                    if (janken.state == Janken.State.SELECT)
                    {
                        janken.OnClickGU();
                    }else
                        if (janken.state == Janken.State.LOSE|| janken.state == Janken.State.WIN)
                    {
                        janken.OnMokkai();
                    }
                        Debug.Log("1");
                    break;
                //-----------------case2
                case 2:
                    if (janken.state == Janken.State.SELECT)
                    {
                        janken.OnClickCHO();
                    }
                    else
                        if (janken.state == Janken.State.LOSE || janken.state == Janken.State.WIN ||janken.state== Janken.State.START)
                    {
                        janken.OnOrari();
                    }
                    //        managerUI.UICanvas.textBox.text = "2";
                    Debug.Log("2");
                    break;
                //-----------------case3
                case 3:
                    if (janken.state == Janken.State.SELECT) janken.OnClickPA();
             //       managerUI.UICanvas.textBox.text = "3";
                    Debug.Log("1");
                    break;
                //-----------------case4
                case 4:
                    
               //     managerUI.UICanvas.textBox.text = "4";
                    Debug.Log("2");
                    break;
            }
            managerUI.UICanvas.selectButton = 0;
        }
    }
    [Serializable]
    public class MessageList
    {
        public string mainMessage;
        public string[] buttonStrings;
    }
}

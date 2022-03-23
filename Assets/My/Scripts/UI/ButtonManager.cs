using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonManager : MonoBehaviour
{
    public CanvasContoller canCon;
   public int myNum;
    public TMP_Text textBox;
    public void OnClickButton()
    {
        canCon.selectButton = myNum;
    }
    
    
    public void  SetMessageText(string text)
    {
        textBox.text = text;
    }
}

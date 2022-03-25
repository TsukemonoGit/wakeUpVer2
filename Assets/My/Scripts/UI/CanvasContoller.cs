using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CanvasContoller : MonoBehaviour
{
    public TMP_Text textBox;
    public int buttonCount;
    public int  selectButton;
    public ButtonManager[] buttons;
    public GameObject panel;

    public void SetCanvas(string text, string[] button, int fontsize1 = 24 , int fontsize2=24)
    {
        panel.SetActive(true);
        textBox.text = text;
        textBox.fontSize = fontsize1;
        for (int i = 0; i < button.Length; i ++)
        { 
            buttons[i].gameObject.SetActive(true);
            buttons[i].SetMessageText(button[i] , fontsize2);
        }
        for (int i =button.Length ;i< buttons.Length; i ++ )
        {
            buttons[i].gameObject.SetActive(false);
        }
    }
    public void SetCanvas()
    {
        panel.SetActive(false);
    }

}

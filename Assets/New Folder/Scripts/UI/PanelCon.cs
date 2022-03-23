using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PanelCon : MonoBehaviour
{
    public TMP_Text text;
    
    public GameObject[] buttons;
    public GameObject activeButton;

    public void SetText(int buttonNum,string _text , int _size ,string _buttonText , int _bSize) 
    {
        activeButton = buttons[buttonNum];
        activeButton.SetActive(true);
        text.text = _text;
        text.fontSize = _size;
        activeButton.GetComponentInChildren<TMP_Text>().text = _buttonText;
        activeButton.GetComponentInChildren<TMP_Text>().fontSize = _bSize;
    }
    
}

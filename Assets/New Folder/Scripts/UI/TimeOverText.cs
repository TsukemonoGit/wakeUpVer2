using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TimeOverText : MonoBehaviour
{
    public GameController gameCon;
    public TMP_Text text;
    public string textString = "配 信 開 始";
    string message;
    private void Start()
    {
        text.text = "";
    }
    public void ViewText()
    {
        StartCoroutine(TextMovie());
    }
    IEnumerator TextMovie()
    {
        for (int i = 0; i < textString.Length; i++)
        {
            message += textString[i].ToString();
            text.text = message;
            yield return new WaitForSeconds(0.25f);
        }
      gameCon.goEnding = true;   
    }
}

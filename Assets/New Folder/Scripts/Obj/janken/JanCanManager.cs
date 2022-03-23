using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JanCanManager : MonoBehaviour
{
    public GameObject select;
    public TMP_Text windowText;

    public void ViewSelect(bool view)
    {
        select.SetActive(view);
    }
    public void SetText(string text)
    {
        windowText.text=text;
    }
}

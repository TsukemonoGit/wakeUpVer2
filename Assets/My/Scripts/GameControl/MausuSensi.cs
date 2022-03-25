using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MausuSensi : MonoBehaviour
{
    GManager manager;
    public Slider slider;
    bool nowView ;
    public GameObject viewObject;
    private void Start()
    {
        manager = GetComponent<GManager>();
        viewObject.SetActive(false);
        nowView = false;
    }
    public void OnValueChange()
    {
   
        manager.model.input.mausukando = (int)slider.value ;
    }
    public void OnButtonClick()
    {
        if (!nowView)
        {
            nowView = true;
            viewObject.SetActive(true);
        }
        else
        {
            nowView = false;
            viewObject.SetActive(false);
        }
    }
}

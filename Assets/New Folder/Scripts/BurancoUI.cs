using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class BurancoUI : MonoBehaviour
{
    public TMP_Text sliderText;
    public Slider slider;
    public GameObject fill;
    public FanzController fanzCon;
    bool _isActive;

    public void SetActiveUI (bool isActive)
    {
if(!fanzCon.isMisshionClear)
        {
            this.gameObject.SetActive(isActive);
            _isActive = isActive;
        }
        else if(_isActive){
            this.gameObject.SetActive(false);
            _isActive = false;
        }
    }
    public void SetText(string text )
    {
        sliderText.text = text;
    }
    public void SetTextColor(Color color)
    {
        sliderText.color = color;
    }
    public void SetValue(int value)
    {
        slider.value = value;
    }
    public void LeapSlider(int value)
    {
        if (nowCoroutine)
        {
            StopCoroutine(coroutine);
        }
        coroutine = StartCoroutine(LeapValue(value));
    }
    Coroutine coroutine;
    bool nowCoroutine;
    public float delta=0.2f;
    IEnumerator LeapValue(int value)
    {
        int muki = 1;
        float sa = value - slider.value;
        nowCoroutine = true;
        if (value < slider.value)
        {
            muki = -1;
            sa *= -1;
        }
        
        while (sa>0) { 
            slider.value+=muki*delta;
            sa = muki*(value - slider.value);
            yield return new WaitForEndOfFrame();
        }
        nowCoroutine = false;
    }
    public void SetSliderColor(Color color)
    {
        fill.GetComponent<Image>().color = color;
    }
    public void SetActiveSlider(bool isActive) {
        slider.gameObject.SetActive(isActive);
    }

}

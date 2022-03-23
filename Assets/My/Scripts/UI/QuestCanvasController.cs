using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class QuestCanvasController : MonoBehaviour
{
    public MovingUI move1;
    private void Awake()
    {
        SetUIActive(false);
    }
    public void SetConstraint(Transform transform)
    {
        move1.constraint = transform;
    }

    public void SetMessage(string message)
    {
        move1.message.text = message;
    }
    public void SetTextColor(Color color)
    {
        move1.message.color = color;
    }
    public void SetSliderMax(int maxValue)
    {
        move1.slider.maxValue = maxValue;
    }
    bool nowCoroutine;
    public void SetSliderValue(int value)
    {
        move1.slider.value = value;
    }
    public void SetSliderColor(Color color)
    {
        move1.fillImage.color = color;
    }
    public void SetActiveSlider(bool value)
    {
        move1.slider.gameObject.SetActive(value);
    }
    public void SetUIActive(bool value)
    {
        move1.gameObject.SetActive(value);
    }
}

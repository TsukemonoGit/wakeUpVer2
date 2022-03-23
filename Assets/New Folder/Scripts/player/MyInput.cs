using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//input systemの入力をpublic の変数に入れる
//別のスクリプトでこれを読み込んで使う

public class MyInput : MonoBehaviour
{
    public bool pause;
    public bool flyMode;
    public Vector2 fly;
    public bool say;
    public bool explain;

    private void Start()
    {
        explain = true;

    }

    //inputSystemで呼ばれる関数を自関数に渡す
    public void OnPause(InputValue value)
    {
        PauseInput(value.isPressed);
     }
   public void OnFlyMode(InputValue value)
    {
        FlyModeInput(value.isPressed);
    }
    public void OnFlyUp(InputValue value)
    {
        FlyUpInput(value.Get<float>());
    }

    public void OnFlyDown(InputValue value)
    {
        FlyDownInput(value.Get<float>());
    }
    public void OnSay(InputValue value)
    {
        SayInput(value.isPressed);
    }

    public void OnExplain(InputValue value)
    {
        Explain(value.isPressed);
    }
    //変数に入れる 
    public void PauseInput(bool newPauseState)
    {
        pause = pause == true ? false : true;       //trueならfalseにfalseならtrueに

        //pause = newPauseState;
        //Debug.Log("pauseKey押された！");
    }
    public void FlyModeInput(bool newFlyModeState)
    {
        flyMode = flyMode == true ? false : true;

       //     Debug.Log("flyKey押された！");
    }
    public void FlyUpInput(float newFlyUpValue) {
        fly.x = newFlyUpValue;
            }
    public void FlyDownInput(float newFlyDownValue)
    {
        fly.y = newFlyDownValue;
    }
    public void SayInput(bool newSayState)
    {
        say = newSayState;
    }     
    public void Explain(bool newEplainState)
    {
        explain = explain == true ? false : true;
    }
}

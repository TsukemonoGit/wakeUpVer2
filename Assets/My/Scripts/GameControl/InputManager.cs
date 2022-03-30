using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public Vector2 move;
    public Vector2 look;
    public bool fire;
    
    public bool pause;
    public bool sprint;
    public bool jump;
    
    public bool flyMode;
    public float fly;
    public bool say;
    public int mausukando;
    
    [Header("設定")]
    public bool analogMovement;

    public bool cursorLocked = true;
    public bool cursorInputForLook = true;

    public void OnMove(InputValue value)
    {
        move = (value.Get<Vector2>());
    }
   
    public void OnLook(InputValue value)
    {
        look = value.Get<Vector2>()* Mathf.Pow( 10 , mausukando*0.1f);
    }

    //public void OnFire(InputValue value)
    //{
    //    fire = value.isPressed;
    //}
    public void OnPause(InputValue value)
    {
        pause = value.isPressed;
    }
    public void OnSprint(InputValue value)
    {
        sprint= value.isPressed;
    }
    public void OnJump(InputValue value)
    {
        jump = value.isPressed;
    }

    public void OnFlyMode(InputValue value)
    {
        flyMode = flyMode == true ? false : true;
    }

    public void OnFly(InputValue value)
    {
        fly = value.Get<float>();
    }
    public void OnSay(InputValue value)
    {
       say= value.isPressed;
    }

    public void OnFire(InputValue value)
    {
        fire = value.isPressed;
    }
    //カーソル
    private void OnApplicationFocus(bool hasFocus)
    {
        SetCursorState(cursorLocked);
    }

    private void SetCursorState(bool newState)
    {
        Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
    }

}

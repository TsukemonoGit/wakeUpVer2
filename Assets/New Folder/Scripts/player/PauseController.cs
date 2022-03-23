
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public InputManager input;
    bool isPause;
    
    private void Update()
    {
        if (input.pause&&!isPause)
        {
            isPause = true;
            CursorVisible(true);
        }   else if( !input.pause && isPause )
        {
            isPause = false;
            CursorVisible(false);
        }
    }
    public void CursorVisible(bool value)
    {
        Cursor.visible = value;
        //カーソルをウインドウ内に
        if (value)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Confined;
        }

        input.cursorLocked = !value;
        input.cursorInputForLook = !value;

    }
}

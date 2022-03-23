using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GManager manager;
    bool _nowPause;
    PlayerController player;
    private void Start()
    {
        player = manager.model.player;
    }
    private void Update()
    {

        if (manager.model.input.pause)
        {
            CursorAndPlayer();

        }
    }
    public void CursorAndPlayer()
    {
        manager.model.input.pause = false;

        if (!_nowPause)
        {
            _nowPause = true;
           player.enabled = false;

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            _nowPause = false;
           player.enabled = true;

            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}

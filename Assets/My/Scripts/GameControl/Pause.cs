using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GManager manager;
    public bool _nowPause;
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
            //        player.enabled = false;
            //     Quaternion rotation = player.CinemachineCameraTarget.transform.rotation;
            //        rotation.y = 0;
            //     player.CinemachineCameraTarget.transform.rotation = rotation;
            //player.CinemachineCameraTarget.transform.LookAt(player.transform);
            //player.CinemachineCameraTarget.transform.rotation = Quaternion.Euler(30, 0, 0);
    
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            _nowPause = false;
            //      player.enabled = true;
           
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}

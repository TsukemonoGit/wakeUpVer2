using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burancoButton : MonoBehaviour
{
    public SetPlayerToObj setobj;
    public void Click()
    {
        setobj.SetActive(!setobj.isActive);
    }
}

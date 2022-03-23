using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SetCanvas;

public class ViewCanvasControl : MonoBehaviour
{
    public MessageList[] list;
    public SetCanvas setCanvas;
    public void SetSetCanvas(int num)
    {
        setCanvas.SetUICanvas(list[num]);
    }
    public void SetSetCanvas()
    {
        setCanvas.SetUICanvas();
    }
}

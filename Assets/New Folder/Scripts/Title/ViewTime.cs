using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ViewTime : MonoBehaviour
{
    public TMP_Text text;
    public void SetTimeList()
    {
        Vector2Int timeVector = SingletonManager.instance.timeList[SingletonManager.instance.timeNum];
        SetTimeString(timeVector);
    }
  void SetTimeString(Vector2Int timeVector)
    {
        text.text = timeVector.x + ":" + timeVector.y.ToString("00") + ":" + "00";
            }
}

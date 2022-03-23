using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fens : MonoBehaviour
{
    public Transform[] borderPos;

    public GameObject fens;
    public float interval=1f;
    bool check=true;
   

    [ContextMenu("フェンス設置")]
    public void SettingFenses()
    {
        int borderNum = 0;
        int number = 0;
        while (check==true) {
            //方向
            int numPlus1;
            if (borderNum  +1>= borderPos.Length)
            {
                numPlus1 =0;
            }
            else
            {
                numPlus1 = borderNum + 1;

            }
            Vector3 direction = borderPos[numPlus1].position - borderPos[borderNum].position;
            float borderLength = Vector3.Magnitude(direction);
            Vector3 position = borderPos[borderNum].position + interval * number * Vector3.Normalize(direction);
            float length = Vector3.Magnitude(position - borderPos[borderNum].position);
            number++;
            Debug.Log(length);
            if (length > borderLength)
            {
                borderNum++;
                number = 0;
                if (borderNum >= borderPos.Length)
                {
                    check = false;
                    break;
                }
                continue;
            }
          
            

                Instantiate(fens, position, Quaternion.identity, transform);
            
            
                
        }
    }

}

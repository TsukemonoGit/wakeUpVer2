using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//タイム管理
//フェイズ管理？
public class GameController : MonoBehaviour
{
    
    public int collected_fanz;

    public List<GameObject> nowFollowings=new List<GameObject>();
    public bool canFollow;
    public int MaxFollowFanz = 5;//一度につれていける数
    public bool isSendingMessage;
    //---timer----
    public TMP_Text timeText;
    [Header("開始時間 (時 , 分)")]
    public Vector2Int  startTime;
    [Header("終了時間 (時 , 分)")]
    public Vector2Int timeLimit;

    public int nowTimeSeconds;
    public int timeLimitSeconds;
    
    float time;
    int timeSec;
    int timeMin;
    int timeHour;
    int preCollect;
    public bool inTime=true;

    public bool goEnding;
    public TimeOverText timeOverText;
    //--------------
    public TMP_Text collectText;
    public InputManager input; 
    void Start()
    {
        
        startTime = SingletonManager.instance.timeList[SingletonManager.instance.timeNum];
        timeLimitSeconds = TimeToSeconds(timeLimit) -  TimeToSeconds(startTime);
        nowTimeSeconds = 0;
        ResetTimer();

    }


    void Update()
    {
        if (goEnding)
        {
            input.pause = true;
            SingletonManager.instance.fadeCon.StartFadeIn(2);
            
            this.enabled=(false);
            return;
        }
        if (!inTime) {
            
            
            return; } 

        if (nowFollowings.Count > MaxFollowFanz)
        {
            canFollow = false;
        }
        else
        {
            canFollow = true;
        }
        if(collected_fanz!=preCollect)
        {
            UpdateText();
        }
       
            Timer();
        
        preCollect = collected_fanz;
    }

    //----------Collect数更新-------------
    void UpdateText()
    {
        collectText.text = collected_fanz.ToString();
    }

    //-----timer------
    [ContextMenu("ResetTimer")]
    void ResetTimer()
    {
        time=Time.time;
        timeSec = 0;
        timeMin = startTime.y;
        timeHour = startTime.x;
        SetTimeToString(new Vector3Int(timeHour, timeMin, timeSec));
        inTime = true;
    }

    void Timer()
    {
        if (Time.time > time + 1)
        { 
            timeSec++;
            time++;
            nowTimeSeconds++;
            if (nowTimeSeconds > timeLimitSeconds - 10)
            {
                timeText.color = Color.red;
            }
            if (timeSec == 60)
            {
                timeSec = 0;
                timeMin++;
                if (timeMin == 60)
                {
                    timeMin = 0;
                    timeHour++;
                }
                if(timeLimit==new Vector2(timeHour, timeMin))
                {
                    TimeLimit();
                    return;
                }
            }
            SetTimeToString(new Vector3Int(timeHour, timeMin, timeSec));

        }
    }

   void SetTimeToString(Vector3Int time)
    {   
       timeText.text=time.x.ToString("00") + ":" + time.y.ToString("00") + ":" + time.z.ToString("00");
    }
    void TimeLimit()
    {
        inTime = false;
        SetTimeToString(new Vector3Int(timeHour, timeMin, timeSec));
        timeText.color = Color.red;
        Debug.Log("Time is UP");
        //score記録
        SingletonManager.instance.score = collected_fanz;
        timeOverText.ViewText();

    }
    int TimeToSeconds(Vector2Int value)
    {
        return value.x * 60 * 60 + value.y * 60;
    }
}

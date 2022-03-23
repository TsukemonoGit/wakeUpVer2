using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour
{
    public GameObject[] canvases;
    public int preCanvas;
    public ViewTime viewTime;

    private void Awake()
    {
        for(int i = 1; i < canvases.Length; i ++)
        {
            canvases[i].SetActive(false);
        }
        canvases[0].SetActive(true);
        preCanvas = 0;
    }

    //---button
    public void OnClickWakeUp()
    {
        SetCanvas(1);

    }
    public void OnClickLevel1()
    {
        SingletonManager.instance.timeNum = 0;
        SetCanvas(2);
        viewTime.SetTimeList();
        StartCoroutine(GameStart());
    }
    public void OnClickLevel2()
    {
        SingletonManager.instance.timeNum = 1;
        SetCanvas(2);
        viewTime.SetTimeList();
        StartCoroutine(GameStart());
    }
    public void OnClickLevel3()
    {
        SingletonManager.instance.timeNum = 2;
        SetCanvas(2);
        viewTime.SetTimeList();
        StartCoroutine(GameStart());
    }

    //
    IEnumerator GameStart()
    {
        yield return new WaitForSeconds(1f);
        SingletonManager.instance.fadeCon.StartFadeIn(1);
    }
    //---
    public  void SetCanvas(int index)
    {     
        canvases[index].SetActive(true);
    canvases[preCanvas].SetActive(false);
    preCanvas = index;
    }
}

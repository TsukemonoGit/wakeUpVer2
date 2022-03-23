using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExplainCanvas : MonoBehaviour
{
    public MyInput input;
    bool isExplain=false;
    public GameObject page1;
    public GameObject  page2;
   
    void Start()
    {
        page1.SetActive(false);
        page2.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        if(input.explain && !isExplain)
        {
            isExplain = true;
            page1.SetActive  (true);
            input.pause = true;
        }
        else if(!input.explain && isExplain)
        {
            isExplain = false;
            page1.SetActive (false);
            page2.SetActive (false);
            input.pause = false;
        }
    }

    public void OnClickFromPage1()
    {
        page2.SetActive (true);
        page1.SetActive(false);
    }
    public void OnClickFromPage2()
    {
        page2.SetActive( false);
        page1.SetActive(true);
    }

    public void OnClickClose()
    {
        input.explain = false;
    }
}

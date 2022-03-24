using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public TMP_Text fanz_count;
    public TMP_Text souhyou;
    int score;
    public int border1;
    [TextArea]
    public string border1Text;

    public int border2;
    [TextArea]
    public string border1Text2;

    public int border3;
    [TextArea]
    public string border1Text3;
    [TextArea]
    public string border1Text4;
    private void Start()
    {
        score = SingletonManager.instance.score;
        SetText();
        SetSouhyou();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    [ContextMenu("SetText")]
    public void SetText()
    {
        fanz_count.text = score.ToString() + "人  ";
    }
    [ContextMenu("souhyou")]
    void SetSouhyou()
    {
        if (score < border1)
        {
            souhyou.text = border1Text;
        }else if (score < border2)
        {
            souhyou.text = border1Text2;
        }else if (score < border3)
        {
            souhyou.text = border1Text3;
        }
        else
        {
            souhyou.text = border1Text4;
        }
    }
    public void OnClickQuit()
    {
        //  UnityEngine.Application.Quit();
        SceneManager.LoadScene(0);
    }
}

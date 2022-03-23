using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nawatobiManager : MonoBehaviour
{
    public GameObject UI;
    //public testes buranco;
    public string[] message;
    public string[] button;
    public int messageFontSize;
    public int buttonFontSize;
    public int nawatobiNum;
    private PanelCon panelCon;
    public int myButtonNum=1;
    public int messageNum = 0;
    private void Awake()
    {
     
        UI.SetActive(false);
        panelCon = UI.GetComponent<PanelCon>();
    }

    private void OnTriggerEnter(Collider other)
    {
        CharacterController character = other.GetComponent<CharacterController>();
        if (character != null)
        {
            panelCon.SetText(myButtonNum,message[messageNum],messageFontSize, button[messageNum],buttonFontSize);
            UI.SetActive(true);
           // Debug.Log("enter");
        }
    }
  
    private void OnTriggerExit(Collider other)
    {
        CharacterController character = other.GetComponent<CharacterController>();

        if (character != null)
        {
            panelCon.activeButton.SetActive(false);
            UI.SetActive(false);
         //   buranco.addForce = false;//ブランコフォースオフに
         //   Debug.Log("Exit");
        }
    }

}
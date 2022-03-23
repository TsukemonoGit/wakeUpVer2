using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MaxAlarm : MonoBehaviour
{

    public GameObject alarmText;
    bool viewText;
    bool coroutineCheck;
    private void OnTriggerEnter(Collider other)
    {
        CharacterController chara = other.GetComponent<CharacterController>();
        if (chara != null)
        {
            alarmText.SetActive(true);
            viewText = true;
            if (!coroutineCheck)
            {
                StartCoroutine(Check());
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        CharacterController chara = other.GetComponent<CharacterController>();
        if (chara != null)
        {
            alarmText.SetActive(false);
            viewText = false;
        }
    }
    IEnumerator Check()
    {
        coroutineCheck = true;
        yield return new WaitForSeconds(10f);
        if (viewText)
        {
            alarmText.SetActive(false);
        }
        coroutineCheck = false;
    }
}
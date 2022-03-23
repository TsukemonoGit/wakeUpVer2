using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCol : MonoBehaviour
{
    public burancoManager buranco;
    private void OnTriggerEnter(Collider other)
    {
        CharacterController character = other.GetComponent<CharacterController>();
        if (character != null)
        {
            buranco.TriggerEnter();
            //     Debug.Log("enter");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        CharacterController character = other.GetComponent<CharacterController>();

        if (character != null)
        {
            buranco.TriggerExit();
        }
    }

}

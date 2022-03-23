using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopFollow : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Following fanz = other.GetComponent<Following>();
        if (fanz != null)
        {
            if (fanz.target = this.gameObject.transform)
            {
                fanz.enabled = false;
            }
        }
    }
}

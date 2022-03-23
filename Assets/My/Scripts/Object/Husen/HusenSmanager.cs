using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HusensManager : MonoBehaviour
{
    public husen[] husens;
    public GameObject target;
    [ContextMenu("Set")]
    private void Start()
    {
        SetTarget();
    }
    public void SetTarget()
    {
        for (int i = 0; i < husens.Length; i++){
            husens[i].target = target;
        }
    }
    private void OnEnable()
    {
        this.transform.position = target.transform.position;
    }
}

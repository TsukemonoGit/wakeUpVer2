﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class husenController : MonoBehaviour
{
    public husen husen;
    // Start is called before the first frame update


    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.position = husen.target.transform.position;
    }
}

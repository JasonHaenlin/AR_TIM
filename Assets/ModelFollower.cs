﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelFollower : MonoBehaviour
{
    public GameObject FloatingText;
    public Transform cam;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(cam != null)
        {
            FloatingText.transform.rotation = cam.rotation;
        }
        
    }
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeSound : MonoBehaviour
{
    public AudioClip TitleBGM;
    public AudioSource aud;

    void Start()
    {
        this.aud = GetComponent<AudioSource>();
       
    }

    
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageM : MonoBehaviour
{

    private AudioSource DamageSeM;          // ダメージSE
    private AudioSource IcSe;               // ICチップSE
    public static int DamageF = 0;
    public static int ICF = 0;

    // Use this for initialization
    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        DamageSeM = audioSources[0];
        IcSe = audioSources[1];
    }

    // Update is called once per frame
    void Update()
    {
        if (DamageF == 1)
        {
            DamageSeM.PlayOneShot(DamageSeM.clip);          // 音鳴らす
            DamageF = 0;
        }
        if (ICF == 1)
        {
            IcSe.PlayOneShot(IcSe.clip);                    // 音鳴らす
            ICF = 0;
        }
    }
}

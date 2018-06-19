using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageM : MonoBehaviour
{

    private AudioSource DamageSeM;           // SE
    public static int DamageF = 0;

    // Use this for initialization
    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        DamageSeM = audioSources[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (DamageF == 1)
        {
            DamageSeM.PlayOneShot(DamageSeM.clip);                    // 音鳴らす
            DamageF = 0;
        }
    }
}

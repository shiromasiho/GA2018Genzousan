using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

    private AudioSource DamageSe;           // SE
    public static int DamageFlg = 0;

	// Use this for initialization
	void Start () {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        DamageSe = audioSources[0];		
	}
	
	// Update is called once per frame
	void Update () {
        if (DamageFlg == 1)
        {
            DamageSe.PlayOneShot(DamageSe.clip);                    // 音鳴らす
            DamageFlg = 0;
        }
	}
}

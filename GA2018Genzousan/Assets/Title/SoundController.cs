using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour {
    public AudioClip ClickSE;

    public bool flgSE = false;
    AudioSource aud;

	// Use this for initialization
	void Start () {
        this.aud = GetComponent<AudioSource>();	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z) && flgSE == false) {
            PlaySound();
        }
	}

    void PlaySound(){        
        this.aud.PlayOneShot(this.ClickSE);
        flgSE = true;
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment_Image3 : MonoBehaviour {
    SpriteRenderer MainSpriteRenderer;
    // publicで宣言し、inspectorで設定可能にする
    public Sprite Bust;
    public Sprite Range_Large;
    public Sprite stock;

    // Use this for initialization
    void Start () {

        //gameObject.SetActive(false);
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        MainSpriteRenderer.sprite = null;
    }
	
	// Update is called once per frame
	void Update () {
        if (Equipment.Equipment_go == 3)    //３回目に出る装備
        {
            switch (Equipment.GameMode)
            {
                case 0:
                    break;
                case 1:
                    MainSpriteRenderer.sprite = Bust;
                    break;
                case 2:
                    MainSpriteRenderer.sprite = Range_Large;
                    break;
                case 3:
                    MainSpriteRenderer.sprite = stock;
                    break;
            }
        }
    }
}

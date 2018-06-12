﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICBox : MonoBehaviour {

    // Use this for initialization
    GameObject player;

    GameObject gamemaindirector;    //変数呼ぶんご
    GameMainDirector maindirector;

    public static int GetICflg = 0;    //ICスキルをゲットした時のflg
    public static int ICflg = 0;        //ICのスキル(randam)

    void Start()
    {
        this.player = GameObject.Find("player");

    }

    // Update is called once per frame
    void Update()
    {
        //飛んでくるやで
        transform.Translate(-0.1f, 0, 0);

        //画面外に出たら破棄
        if (transform.position.x < -8.0f)
        {
            Destroy(gameObject);
        }

    }
    //全員消す
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        ICBox.GetICflg = 1;
        Debug.Log("とったで工藤");
        PICchip.IC_flg = 0;
    }

}

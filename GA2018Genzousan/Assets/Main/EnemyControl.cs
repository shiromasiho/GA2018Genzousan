﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {

    Rigidbody2D rigid2D;
    Animator animator;
    BoxCollider2D Enemy_ObjectCollider;
    float Enemymove;                    // １フレームで動く単位
    float Enemypos;                      // enemyの初期ポジションｘ
    public static int EnemyFlg;            // 動くフラグ
    int StayFlg;                            // 一時停止フラグ
    int StayCount;   // 停止時間
    float maxWalkSpeed = 2.0f;

    PICchip pICchip;

    //体力で絵が変わる
    SpriteRenderer MainSpriteRenderer;
    public Sprite enemyImg1;
    public Sprite enemyImg2;
    public Sprite enemyImg3;
    public Sprite enemyImg4;
    public static int enemyImgD; //enemyのダメージ


    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();

        Enemy_ObjectCollider = gameObject.GetComponent<BoxCollider2D>();
        Enemy_ObjectCollider.isTrigger = false;

        Enemymove = 0.02f;        // １フレームで動く単位
        Enemypos = 6.34f;
        EnemyFlg = 0;            //（０→動かない、１→手前へ、２→奥へ）
        StayFlg = 0;
        StayCount = 120;             // （120 → ２秒）
    }

    void Update()
    {

        Vector3 pos = transform.position;
        enemyImgD = GameMainDirector.enemyHp;
      
        if (EnemyFlg == 0) Enemy_ObjectCollider.isTrigger = true;                  // 当たり判定解除
        else               Enemy_ObjectCollider.isTrigger = false;                 // 当たり判定実装


        if ((pos.x >= (Enemypos - 3)) && (EnemyFlg == 1) && (StayFlg == 0))
        {
            pos.x -= Enemymove;             // 手前へ移動
            if (pos.x <= (Enemypos - 3))       // １番手前に来た時の停止
            {
                EnemyFlg = 2;
                StayFlg = 1;                // 停止する
            }
        }

        if ((pos.x <= (Enemypos)) && (EnemyFlg == 2) && (StayFlg == 0))
        {
            pos.x += Enemymove;             // 奥に移動
            if (pos.x >= (Enemypos))         // １番奥に来た時の停止
            {
                EnemyFlg = 1;
                StayFlg = 1;                // 停止する
                PICchip.IC_flg = 1; //IC飛んだ
            }
        }

        if (StayFlg == 1)
        {
            StayCount--;

            if (StayCount == 0)
            {
                ShieldControl.RBCount--;
                StayCount = 120;                        // enemyの一時停止
                StayFlg = 0;                            // 移動再開
                if (ShieldControl.RBCount == 1)
                {
                    ShieldControl.BF = 3;                 // バリア再配置
                    ShieldControl.BFChange = 0;
                }
                else if (ShieldControl.RBCount == 0)
                {
                    FireGeneratorS.GeneFlg = 1;      // 弾再生成
                    FireGeneratorS.GeneFlg2 = 1;
                    EnemyFlg = 0;                       // enemyの停止
                }
            }
        }

        transform.position = pos;                       // enemyの座標変更

        if (GameMainDirector.enemyHp == 50)
        {
            this.animator.SetTrigger("Dmg1Trigger");
            Debug.Log("殴られたのだ");
        }
        if (GameMainDirector.enemyHp == 30)
        {
            this.animator.SetTrigger("Dmg2Trigger");
            Debug.Log("ロコちゃんが帰ってこないのだ");
        }
        if (GameMainDirector.enemyHp == 10)
        {
            this.animator.SetTrigger("Dmg3Trigger");
            Debug.Log("ぶたないでほしいのだ");
        }
    }

}

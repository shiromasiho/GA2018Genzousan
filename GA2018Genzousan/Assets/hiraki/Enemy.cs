﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    Rigidbody2D rigid2D;
    Animator animator;
    float Enemymove = 0.02f;                    // １フレームで動く単位
    float Enemypos = 6.34f;                     // enemyの初期ポジション
    public  static int EnemyFlg = 0;            // 動くフラグ（０→動かない、１→手前へ、２→奥へ）
    int StayFlg = 0;                            // 一時停止フラグ
    int StayCount = 120;                        // 停止時間（120 → ２秒）

	void Start () {
        this.rigid2D = GetComponent<Rigidbody2D>();		
	}
	
	void Update () {
        Vector3 pos = transform.position;

        if ((pos.x >= (Enemypos-3)) && (EnemyFlg == 1) && (StayFlg == 0))
        {
            pos.x -= Enemymove;             // 手前へ移動
            if (pos.x <= (Enemypos-3))       // １番手前に来た時の停止
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
            }
        }

        if (StayFlg == 1)
        {
            StayCount--;

            if (StayCount == 0)
            {
                BarrierForm.RBCount--;
                StayCount = 120;                        // enemyの一時停止
                StayFlg = 0;                            // 移動再開
                if(BarrierForm.RBCount == 1)
                {
                    BarrierForm.BF = 3;                 // バリア再配置
                    BarrierForm.BFChange = 0;
                }
                else if(BarrierForm.RBCount == 0)
                {
                    EnemyFireGenerate.GeneFlg = 1;      // 弾再生成
                    EnemyFlg = 0;                       // enemyの停止
                }
           }
        }

        transform.position = pos;                       // enemyの座標変更
	}
}
    
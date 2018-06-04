using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierForm : MonoBehaviour
{
    //シールド生成
    SpriteRenderer MainSpriteRenderer;
    public Sprite Barrier1Prefab;
    public Sprite Barrier2Prefab;
    public Sprite Barrier3Prefab;
    public Sprite Barrier4Prefab;

    // 自作
    public static int BF = 3;           // バリアの体力
    public static int RBCount = 0;      // バリア再配置カウント
    public static int BFChange = 0;     // バリアの回復処理入り (体力が１から２へ移行した時に、もう１０秒カウントする)
    int BFCount;                        // バリアの時間回復変数
    int BFC = 600;                      // バリアの回復時間
    int BF2;                            // バリアの体力の比較用

    BoxCollider2D m_ObjectCollider;

    void Start()
    {
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        m_ObjectCollider = gameObject.GetComponent<BoxCollider2D>();
        m_ObjectCollider.isTrigger = false;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))            // SPACEキーで体力減少
        {
            BF--;                                       // 体力減少
            BFChange = 1;
            BFCount = BFC;
        }

        if (RBCount <= 1)
        {
            switch (BF)
            {
                case 3:
                    MainSpriteRenderer.sprite = Barrier1Prefab;         // 第１段階のバリア描画
                    m_ObjectCollider.isTrigger = false;                 // 当たり判定実装
                    break;

                case 2:
                    MainSpriteRenderer.sprite = Barrier2Prefab;         // 第２段階のバリア描画
                    break;

                case 1:
                    MainSpriteRenderer.sprite = Barrier3Prefab;         // 第３段階のバリア描画
                    break;

                case 0:
                    MainSpriteRenderer.sprite = Barrier4Prefab;         // 描画（画像無し）
                    m_ObjectCollider.isTrigger = true;                  // 当たり判定解除
                    EnemyFireGenerate.GeneFlg = 0;                      // 弾生成中止
                    RBCount = 4;
                    Enemy.EnemyFlg = 1;                                 // ボスが動き出す
                    break;
            }

            if (BFChange == 1)
            {
                if (BF != 0)
                {
                    BF2 = BF;
                    BFCount--;

                    if (BFCount == 0)
                    {
                        if (BF2 == BF)
                        {
                            BF++;
                            if (BF == 2) BFCount = BFC;      // もう１度数える
                             else        BFChange = 0;
                        }
                    }
                }
            }
        }
    }
}
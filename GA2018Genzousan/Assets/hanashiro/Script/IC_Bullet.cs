using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IC_Bullet : MonoBehaviour {
    float ICBuletspeed = -0.13f;  //ICチップの速度
    GameObject player;
    int box;    //ICチップランダム格納
  
    static int IC_go;   // ICチップ呼び出しカウント
    public static int Jumpflg; //ジャンプフラグ
    public static int Shot_rangeflg;   //範囲大フラグ
    public static int Dimflg;  //画面暗転フラグ

    // Use this for initialization
    void Start () {
        
       
        this.player = GameObject.Find("player");
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(ICBuletspeed, 0, 0);

        if (transform.position.x < -8.0f)
        {
            Destroy(gameObject);    //弾が画面外にいくと弾を消す
        }
        if (Bulletstrike.playerP !=0)
        {
            //あたり判定
            Vector2 p1 = transform.position;
            Vector2 p2 = this.player.transform.position;
            Vector2 dir = p1 - p2;
            float d = dir.magnitude;
            float r1 = 0.3f;
            float r2 = 1.0f;

            if (d < r1 + r2)    //プレイヤーと弾が当たった時
            {

                Destroy(gameObject);

                if (IC_go == 0) //１回目のICチップの中身
                {
                    box = Random.Range(1, 4);   //変数にランダムの数を格納

                    if (box == 1)   //ジャンプ機能呼び出し
                    {
                        Jumpflg = 1;
                        Debug.Log("ジャンプ" + Jumpflg);
                    }
                    else if (box == 2)  //範囲大機能呼び出し
                    {
                        Shot_rangeflg = 1;
                        Debug.Log("範囲大" + Shot_rangeflg);
                    }
                    else if (box == 3)  //画面暗転機能呼び出し
                    {
                        Dimflg = 1;
                        Debug.Log("画面暗転" + Dimflg);
                    }
                    IC_go++;
                   
                    Debug.Log("IC_go" + IC_go);
                   

                }

                else if (IC_go == 1)    //2回目のICチップの中身
                {
                    if (Jumpflg == 1)
                    {
                        box = Random.Range(1, 3);   //変数にランダムの数を格納

                        if (box == 1)  //範囲大機能呼び出し
                        {
                            Shot_rangeflg = 1;
                            Debug.Log("範囲大" + Shot_rangeflg);
                        }
                        else if (box == 2)  //画面暗転機能呼び出し
                        {
                            Dimflg = 1;
                            Debug.Log("画面暗転" + Dimflg);
                        }
                        IC_go++;
                       
                        Debug.Log("IC_go" + IC_go);
                       

                    }
                    else if (Shot_rangeflg == 1)
                    {
                        box = Random.Range(1, 3);   //変数にランダムの数を格納
                        if (box == 1)   //ジャンプ機能呼び出し
                        {
                            Jumpflg = 1;
                            Debug.Log("ジャンプ" + Jumpflg);
                        }

                        else if (box == 2)  //画面暗転機能呼び出し
                        {
                            Dimflg = 1;
                            Debug.Log("画面暗転" + Dimflg);
                        }
                        IC_go++;

                        Debug.Log("IC_go" + IC_go);

                    }
                    else if (Dimflg == 1)
                    {
                        box = Random.Range(1, 3);   //変数にランダムの数を格納
                        if (box == 1)   //ジャンプ機能呼び出し
                        {
                            Jumpflg = 1;
                            Debug.Log("ジャンプ" + Jumpflg);
                        }
                        else if (box == 2)  //範囲大機能呼び出し
                        {
                            Shot_rangeflg = 1;
                            Debug.Log("範囲大" + Shot_rangeflg);
                        }
                        IC_go++;
                        
                        Debug.Log("IC_go" + IC_go);
                        

                    }
                }

                else if (IC_go == 2)    //３回目のICチップの中身
                {
                    if (Jumpflg == 1&&Shot_rangeflg==1)
                    {
                        box = 2;   //変数にランダムの数を格納

                        
                         if (box == 2)  //画面暗転機能呼び出し
                        {
                            Dimflg = 1;
                            Debug.Log("画面暗転" + Dimflg);
                        }
                        IC_go++;
                      
                        Debug.Log("IC_go" + IC_go);
                      

                    }
                    else if (Jumpflg==1&&Dimflg == 1)
                    {
                        box = 2; //変数にランダムの数を格納
                       if (box == 2)  //範囲大機能呼び出し
                        {
                            Shot_rangeflg = 1;
                            Debug.Log("範囲大" + Shot_rangeflg);
                        }
                       
                        IC_go++;
                     
                        Debug.Log("IC_go" + IC_go);
                       
                    }
                    else if (Shot_rangeflg==1&&Dimflg==1)
                    {
                        box =1;   //変数にランダムの数を格納
                        if (box == 1)   //ジャンプ機能呼び出し
                        {
                            Jumpflg = 1;
                            Debug.Log("ジャンプ" + Jumpflg);
                        }
                       
                        IC_go++;
                       
                        Debug.Log("IC_go" + IC_go);
                        IC_go = 0;
                        Debug.Log("IC_go初期化" + IC_go);
                       
                    }
                   

                }

            }
        }
    }
}

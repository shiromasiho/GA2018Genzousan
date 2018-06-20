using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PICchip : MonoBehaviour {
    public static int Jumpflg;  //ジャンプ
    public static int Continuous_shootingflg;   //三連
    public static int Dimflg; //暗転
    int box;    //ランダム格納
    public static int IC_go;    //装備回数カウント
    public static int GameMode;
    public static int IC_flg;
    public static int riseto;
    // Use this for initialization
    void Start()
    {
        GameMode = 0;
        IC_flg = 0;

    }

    // Update is called once per frame
    void Update()
    {
    //    if (Input.GetKeyDown("b"))
        if (ICBox.GetICflg ==1)
        {
            ICBox.GetICflg = 0;
            if (IC_flg == 0) //取得flg
            {

                if (IC_go == 0) //１回目の装備の中身
                {
                    box = Random.Range(1, 4);   //変数にランダムの数を格納
                    //  box = 1;
                    if (box == 1)   //ジャンプ機能呼び出し
                    {

                        Jumpflg = 1;
                        Debug.Log("ジャンプ" + Jumpflg);
                        GameMode = 1;

                    }
                    else if (box == 2)  //3連射機能呼び出し
                    {

                        Continuous_shootingflg = 1;
                        Debug.Log("3連射" + Continuous_shootingflg);
                        GameMode = 2;
                    }
                    else if (box == 3)  //暗転機能呼び出し
                    {

                        Dimflg = 1;
                        Debug.Log("暗転" + Dimflg);
                        GameMode = 3;
                    }
                    IC_go++;

                    Debug.Log("IC_go" + IC_go);

                }

                else if (IC_go == 1)    //2回目の装備の中身
                {
                    if (Jumpflg == 1)
                    {
                        box = Random.Range(1, 3);   //変数にランダムの数を格納

                        if (box == 1)  //3連射機能呼び出し
                        {

                            Continuous_shootingflg = 1;
                            Debug.Log("3連射" + Continuous_shootingflg);
                            GameMode = 2;
                        }
                        else if (box == 2)  //暗転機能呼び出し
                        {
                            Dimflg = 1;
                            Debug.Log("暗転" + Dimflg);
                            GameMode = 3;
                        }
                        IC_go++;

                        Debug.Log("IC_go" + IC_go);


                    }
                    else if (Continuous_shootingflg == 1)
                    {
                        box = Random.Range(1, 3);   //変数にランダムの数を格納
                        if (box == 1)   //ジャンプ機能呼び出し
                        {
                            Jumpflg = 1;
                            Debug.Log("ジャンプ" + Jumpflg);
                            GameMode = 1;
                        }

                        else if (box == 2)  //暗転機能呼び出し
                        {
                            Dimflg = 1;
                            Debug.Log("暗転" + Dimflg);
                            GameMode = 3;
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
                            GameMode = 1;
                        }
                        else if (box == 2)  //3連射機能呼び出し
                        {
                            Continuous_shootingflg = 1;
                            Debug.Log("3連射" + Continuous_shootingflg);
                            GameMode = 2;
                        }
                        IC_go++;

                        Debug.Log("IC_go" + IC_go);


                    }
                }

                else if (IC_go == 2)    //３回目の装備の中身
                {
                    if (Jumpflg == 1 && Continuous_shootingflg == 1)
                    {
                        box = 2;   //変数にランダムの数を格納


                        if (box == 2)  //暗転機能呼び出し
                        {
                            Dimflg = 1;
                            Debug.Log("暗転" + Dimflg);
                            GameMode = 3;
                        }
                        IC_go++;

                        Debug.Log("IC_go" + IC_go);


                    }
                    else if (Jumpflg == 1 && Dimflg == 1)
                    {
                        box = 2; //変数にランダムの数を格納
                        if (box == 2)  //3連射機能呼び出し
                        {
                            Continuous_shootingflg = 1;
                            Debug.Log("3連射" + Continuous_shootingflg);
                            GameMode = 2;
                        }

                        IC_go++;

                        Debug.Log("IC_go" + IC_go);

                    }
                    else if (Continuous_shootingflg == 1 && Dimflg == 1)
                    {
                        box = 1;   //変数にランダムの数を格納
                        if (box == 1)   //ジャンプ機能呼び出し
                        {
                            Jumpflg = 1;
                            Debug.Log("ジャンプ" + Jumpflg);
                            GameMode = 1;
                        }

                        IC_go++;

                        Debug.Log("IC_go" + IC_go);

                    }

                }

            }
        }
        else if (IC_flg == 1)    //攻撃受けたから０やで
        {
            riseto = 1;
            IC_go = 0;
            GameMode = 0;
            Continuous_shootingflg = 0;
            Jumpflg = 0;
            Dimflg = 0;

            IC_flg = 0;
            Debug.Log("aaaa" + IC_go);
            Debug.Log("ジャンプ" + Jumpflg);
            Debug.Log("3連射" + Continuous_shootingflg);
            Debug.Log("暗転" + Dimflg);
            Debug.Log("ICを消したい！！");
        }
    }
}

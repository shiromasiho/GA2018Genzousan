using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PEquipment : MonoBehaviour
{
    public static int Bustflg;  //ブースト
    public static int Range_Largeflg;   //範囲大
    public static int stockflg; //ストック
    int box;    //ランダム格納
    public static int Equipment_go;    //装備回数カウント
    public static int GameMode = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.Keypad8)&& Input.GetKey(KeyCode.Keypad1)&& Input.GetKey(KeyCode.Keypad0))
        if (Input.GetKeyUp(KeyCode.A))
        {
            if (Equipment_go == 0) //１回目の装備の中身
            {
                box = Random.Range(1, 4);   //変数にランダムの数を格納
                //  box = 1;
                if (box == 1)   //ブースト機能呼び出し
                {

                    Bustflg = 1;
                    Debug.Log("ブースト" + Bustflg);
                    GameMode = 1;

                }
                else if (box == 2)  //範囲大機能呼び出し
                {

                    Range_Largeflg = 1;
                    Debug.Log("範囲大" + Range_Largeflg);
                    GameMode = 2;
                }
                else if (box == 3)  //ストック機能呼び出し
                {

                    stockflg = 1;
                    Debug.Log("ストック" + stockflg);
                    GameMode = 3;
                }
                Equipment_go++;

                Debug.Log("Equipment_go" + Equipment_go);

            }

            else if (Equipment_go == 1)    //2回目の装備の中身
            {
                if (Bustflg == 1)
                {
                    box = Random.Range(1, 3);   //変数にランダムの数を格納

                    if (box == 1)  //範囲大機能呼び出し
                    {

                        Range_Largeflg = 1;
                        Debug.Log("範囲大" + Range_Largeflg);
                        GameMode = 2;
                    }
                    else if (box == 2)  //ストック機能呼び出し
                    {
                        stockflg = 1;
                        Debug.Log("ストック" + stockflg);
                        GameMode = 3;
                    }
                    Equipment_go++;

                    Debug.Log("Equipment_go" + Equipment_go);


                }
                else if (Range_Largeflg == 1)
                {
                    box = Random.Range(1, 3);   //変数にランダムの数を格納
                    if (box == 1)   //ブースト機能呼び出し
                    {
                        Bustflg = 1;
                        Debug.Log("ブースト" + Bustflg);
                        GameMode = 1;
                    }

                    else if (box == 2)  //ストック機能呼び出し
                    {
                        stockflg = 1;
                        Debug.Log("ストック" + stockflg);
                        GameMode = 3;
                    }
                    Equipment_go++;

                    Debug.Log("Equipment_go" + Equipment_go);

                }
                else if (stockflg == 1)
                {
                    box = Random.Range(1, 3);   //変数にランダムの数を格納
                    if (box == 1)   //ブースト機能呼び出し
                    {
                        Bustflg = 1;
                        Debug.Log("ブースト" + Bustflg);
                        GameMode = 1;
                    }
                    else if (box == 2)  //範囲大機能呼び出し
                    {
                        Range_Largeflg = 1;
                        Debug.Log("範囲大" + Range_Largeflg);
                        GameMode = 2;
                    }
                    Equipment_go++;

                    Debug.Log("Equipment_go" + Equipment_go);


                }
            }

            else if (Equipment_go == 2)    //３回目の装備の中身
            {
                if (Bustflg == 1 && Range_Largeflg == 1)
                {
                    box = 2;   //変数にランダムの数を格納


                    if (box == 2)  //ストック機能呼び出し
                    {
                        stockflg = 1;
                        Debug.Log("ストック" + stockflg);
                        GameMode = 3;
                    }
                    Equipment_go++;

                    Debug.Log("Equipment_go" + Equipment_go);


                }
                else if (Bustflg == 1 && stockflg == 1)
                {
                    box = 2; //変数にランダムの数を格納
                    if (box == 2)  //範囲大機能呼び出し
                    {
                        Range_Largeflg = 1;
                        Debug.Log("範囲大" + Range_Largeflg);
                        GameMode = 2;
                    }

                    Equipment_go++;

                    Debug.Log("Equipment_go" + Equipment_go);

                }
                else if (Range_Largeflg == 1 && stockflg == 1)
                {
                    box = 1;   //変数にランダムの数を格納
                    if (box == 1)   //ブースト機能呼び出し
                    {
                        Bustflg = 1;
                        Debug.Log("ブースト" + Bustflg);
                        GameMode = 1;
                    }

                    Equipment_go++;

                    Debug.Log("Equipment_go" + Equipment_go);

                }


            }
        }
    }
}


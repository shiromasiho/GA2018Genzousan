//メイン画面にて画面を暗転させる処理
//Zキー入力で処理に入る
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BlackOut : MonoBehaviour
{
    float fadeSpeed = 0.2f;        //透明度が変わるスピードを管理
    float red, green, blue, alfa;   //パネルの色、不透明度を管理
    float  TimeLimit = 3.0f;        //明るくなるまでの時間。暗転時間を調整するならここです
    float TimeSpeed = 0.02f;
    public bool isBlackOut = false;  //フェードアウト処理の開始、完了を管理するフラグ

    Image fadeImage;                //透明度を変更するパネルのイメージ

    void Start()
    {
        fadeImage = GetComponent<Image>();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) { isBlackOut = true; }

        if (isBlackOut)
        {
            StartFadeOut();
        }
    }

    void StartFadeOut()
    {
        fadeImage.enabled = true;  // パネルの表示をオンにする
        alfa += fadeSpeed;         //不透明度を徐々にあげる
        SetAlpha();               // 変更した透明度をパネルに反映する
        TimeLimit -= TimeSpeed;
        if (TimeLimit <= 0)
        {             // パネルを不透明にしてからtimeが0になれば、透明にして処理を抜ける
            isBlackOut = false;
            alfa = 0;
            SetAlpha();
        }
    }

    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }
}
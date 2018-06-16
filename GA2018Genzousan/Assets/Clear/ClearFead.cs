using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearFead : MonoBehaviour
{

    float fadeSpeed = 0.02f;        //透明度が変わるスピードを管理
    float red, green, blue, alfa;   //パネルの色、不透明度を管理
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
        if (ClearScene.ClickFlg == 1)
        {
            if (Input.GetKeyDown(KeyCode.Space)) isBlackOut = true;
        }
        if (isBlackOut) EndFadeOut();
    }

    void EndFadeOut()
    {
        fadeImage.enabled = true;  // パネルの表示をオンにする
        alfa += fadeSpeed;         // 不透明度を徐々に上げる
        SetAlpha();                // 変更した透明度をパネルに反映する
        if (alfa >= 255)
        {             // 画面が完全に暗くなれば、透明にして処理を抜ける
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
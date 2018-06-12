using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OverSelect : MonoBehaviour {

    public const int BUTTON_NUM = 2;        // ボタンの数
    private Sprite[] CursorSprite;

    public Image[] SelectImage;             // ボタンの画像の割り当て
    public Button[] SelectButton;           // ボタンの割り当て
    public RectTransform CursorPosition;    // カーソルの割り当て

    int SelectCount = 0;                    // カーソルの初期位置
	
	void Update () {

        // 『←』でカーソルを左へ移動
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            SelectCount--;

            if (SelectCount < 0)                            // 左端だとカーソルが動かない処理
            {
                SelectCount = 0;
            }
        }

        // 『→』でカーソルを右へ移動
        else if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            SelectCount++;

            if (SelectCount >= SelectImage.Length)          // 右端だとカーソルが動かない処理
            {
                SelectCount = SelectImage.Length - 1;
            }
        }

        // スペースボタンで決定
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            SelectButton[SelectCount].Select();

            //if (MenuCount == 0) Invoke("ContinueButton", 1f);
            //if (MenuCount == 1) Invoke("TitleButton", 1f);

            if (SelectCount == 0) ContinueButton();
            if (SelectCount == 1) TitleButton();

        }
        CursorPosition.localPosition = SelectImage[SelectCount].rectTransform.localPosition;
	}

    // コンティニューする
    public void ContinueButton()
    {
        Debug.Log("コンティニュー");
        //SceneManager.LoadScene("Genzoumain");
        SceneManager.LoadScene("Main Scene");
    }

    // タイトルへ
    public void TitleButton()
    {
        Debug.Log("タイトル");
        SceneManager.LoadScene("Title Scene");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OverSelect : MonoBehaviour {

    private Sprite[] CursorSprite;
    private AudioSource SelectSe;           // 決定SE
    public const int BUTTON_NUM = 2;        // ボタンの数

    public Image[] SelectImage;             // ボタンの画像の割り当て
    public Button[] SelectButton;           // ボタンの割り当て
    public RectTransform CursorPosition;    // カーソルの割り当て

    int SelectCount = 0;                    // カーソルの初期位置
	int SceneFlg = 0;                       // Sceneの移動を１度だけ確認するフラグ
    public static int SelectFlg = 0;        // フェード院している間は操作を禁止するフラグ
    float SelectTime = 60.0f;               // 操作を禁止する時間（60.0f ＝ １秒）

    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        SelectSe = audioSources[0];
    }

    void Update()
    {
        SelectTime--;
        if (SelectTime == 0) SelectFlg = 1;         // 操作解禁

        if (SelectFlg == 1)
        {
            
            // 『↑』でカーソルを上へ移動
            if ((Input.GetKeyDown(KeyCode.UpArrow) == true) && (SceneFlg == 0))
            {
                SelectCount--;

                if (SelectCount < 0)                        // カーソルが既に上にあるとカーソルが動かない処理
                {
                    SelectCount = 0;
                }
            }

            // 『↓』でカーソルを下へ移動
            else if ((Input.GetKeyDown(KeyCode.DownArrow) == true) && (SceneFlg == 0))
            {
                SelectCount++;

                if (SelectCount >= SelectImage.Length)      // カーソルが既に下にあるとカーソルが動かない処理
                {
                    SelectCount = SelectImage.Length - 1;
                }
            }

            // スペースボタンで決定
            if (Input.GetKeyDown(KeyCode.Space) == true)
            {
                SceneFlg++;
                //SelectButton[SelectCount].Select();           // こいつよくわからんけど要らないっぽい

                if (SceneFlg == 1)
                {
                    SelectSe.PlayOneShot(SelectSe.clip);                    // 選択音鳴らす
                    if (SelectCount == 0) Invoke("ContinueButton", 1.5f);   // 1.5秒後に『コンティニューする』へ
                    if (SelectCount == 1) Invoke("TitleButton", 1.5f);      // 1.5秒後に『タイトルに移動する』へ
                }
            }
            CursorPosition.localPosition = SelectImage[SelectCount].rectTransform.localPosition;
        }
    }

    // コンティニューする
    public void ContinueButton()
    {
        Debug.Log("コンティニュー");
        SceneManager.LoadScene("Main Scene");       // Scene移動
    }

    // タイトルに移動する
    public void TitleButton()
    {
        Debug.Log("タイトル");
        SceneManager.LoadScene("Title Scene");      // Scene移動
    }
}
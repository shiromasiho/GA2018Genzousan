using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearScene : MonoBehaviour
{

    private AudioSource ClearClickSe;       // 決定SE

    int TitleSFlg = 0;                       // Sceneの移動を１度だけ確認するフラグ
    public static int ClickFlg = 0;        // フェード院している間は操作を禁止するフラグ
    float TitleSTime = 60.0f;               // 操作を禁止する時間（60.0f ＝ １秒）

    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        ClearClickSe = audioSources[0];
    }

    void Update()
    {
        TitleSTime--;
        if (TitleSTime == 0) ClickFlg = 1;         // 操作解禁

        if (ClickFlg == 1)
        {

            // スペースボタンでタイトルへ
            if (Input.GetKeyDown(KeyCode.Space) == true)
            {
                TitleSFlg++;

                if (TitleSFlg == 1)
                {
                    ClearClickSe.PlayOneShot(ClearClickSe.clip);    // 選択音鳴らす
                    Invoke("TitleS", 1.5f);                 // 1.5秒後に『タイトルに移動する』へ
                }
            }
        }
    }

    // タイトルに移動する
    public void TitleS()
    {
        Debug.Log("タイトル");
        SceneManager.LoadScene("Title Scene");      // Scene移動
    }
}
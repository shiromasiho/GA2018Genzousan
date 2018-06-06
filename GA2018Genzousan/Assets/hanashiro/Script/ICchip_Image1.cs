using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICchip_Image1 : MonoBehaviour {

    SpriteRenderer MainSpriteRenderer;
    // publicで宣言し、inspectorで設定可能にする
    public Sprite Jump; //ジャンプ機能画像
    public Sprite Continuous_shooting;  //3連写
    public Sprite Dim;  //暗転機能画像

    // Use this for initialization
    void Start () {

        //gameObject.SetActive(false);
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        MainSpriteRenderer.sprite = null;
    }
	
	// Update is called once per frame
	void Update () {
        if (IC_Bullet.IC_go == 1)    //１回目に出る装備
        {
            switch (IC_Bullet.IC_GameMode)
            {
                case 0:
                    break;
                case 1:
                    MainSpriteRenderer.sprite = Jump;   //spriteを入れ替え
                    break;
                case 2:
                    MainSpriteRenderer.sprite = Continuous_shooting;
                    break;
                case 3:
                    MainSpriteRenderer.sprite = Dim;
                    break;
            }
        }

    }
}

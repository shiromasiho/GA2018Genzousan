using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipskill_3 : MonoBehaviour {

    SpriteRenderer MainSpriteRenderer;
    // publicで宣言し、inspectorで設定可能にする

    public Sprite Bust; //ブースト機能画像
    public Sprite Range_Large; //範囲大機能画像
    public Sprite stock;    //ストック機能画像

    // public static int Image_go=0;
    // Use this for initialization
    void Start()
    {

        //gameObject.SetActive(false);
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        MainSpriteRenderer.sprite = null;
    }


    // Update is called once per frame
    void Update()
    {
        if (Equipment.Equipment_go == 1)    //１回目に出る装備
        {
            switch (Equipment.GameMode)
            {
                case 0:
                    break;
                case 1:
                    MainSpriteRenderer.sprite = Bust;   //spriteを入れ替える
                    break;
                case 2:
                    MainSpriteRenderer.sprite = Range_Large;
                    break;
                case 3:
                    MainSpriteRenderer.sprite = stock;
                    break;
            }
        }

    }
}

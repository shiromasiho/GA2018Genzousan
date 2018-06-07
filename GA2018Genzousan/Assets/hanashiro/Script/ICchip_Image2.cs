using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICchip_Image2 : MonoBehaviour {
    SpriteRenderer MainSpriteRenderer;
    // publicで宣言し、inspectorで設定可能にする
    public Sprite Jump;
    public Sprite Continuous_shooting;
    public Sprite Dim;

    // Use this for initialization
    void Start () {

        //gameObject.SetActive(false);
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        MainSpriteRenderer.sprite = null;
    }
	
	// Update is called once per frame
	void Update () {
        if (IC_Bullet.IC_go == 2)    //2回目に出る装備
        {
            switch (IC_Bullet.IC_GameMode)
            {
                case 0:
                    break;
                case 1:
                    MainSpriteRenderer.sprite = Jump;
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

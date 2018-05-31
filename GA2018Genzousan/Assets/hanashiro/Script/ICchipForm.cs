using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICchipForm : MonoBehaviour {

    public GameObject ICchipPrehub;

    public static int ICchipBulletswitch = 0;   //ICチップを生成する変数
    float span=10.0f;   //ICチップ生成待機時間
    float IC_get = 0;   

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (ICchipBulletswitch==0&&shieldForm.bariaswitch==1)   //バリアHPが３の場合にICチップを生成するフラグを立てる
        {
            ICchipBulletswitch = 1;
           
        }
        if (ICchipBulletswitch == 1)    //ICチップ生成し、１度だけ生成したら、生成を止める
        {
            this.IC_get += Time.deltaTime;
            if (this.IC_get > this.span)
            {

                this.IC_get = 0;
                GameObject IC = Instantiate(ICchipPrehub) as GameObject;
                ICchipBulletswitch = 2;
               
            }
            
        }
        else if (shieldForm.bariaswitch == 0)   //バリアがリセットされるタイミングでICチップを生成するためのフラグを立てる
        {
            ICchipBulletswitch = 0;
        }

    }
}

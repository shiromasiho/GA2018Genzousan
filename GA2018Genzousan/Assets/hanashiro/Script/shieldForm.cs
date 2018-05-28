using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldForm : MonoBehaviour
{
    //シールド生成
    SpriteRenderer MainSpriteRenderer;
    public GameObject baria1Prehub;
    public GameObject baria2Prehub;
    public GameObject baria3Prehub;

    public static int bariaswitch = 1; //シールド生成管理変数
    public GameObject baria1;
    public GameObject baria2;
    public GameObject baria3;

    float span = 10.0f; //バリアの生成待機時間
    float delta = 0;
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (bariaswitch == 1)
        {

             baria1 = Instantiate(baria1Prehub) as GameObject;
            bariaswitch = 0;

        }
        else if (bariaswitch == 2)
        {
         
            baria2 = Instantiate(baria2Prehub) as GameObject;
            bariaswitch = 0;
        }
        else if (bariaswitch == 3)
        {
            baria3 = Instantiate(baria3Prehub) as GameObject;
            bariaswitch = 0;
        }
        else if (bariaswitch == 0)  //バリアHPがないとき経過時間になるとバリア回復
        {
            this.delta += Time.deltaTime;
            if (this.delta > this.span)
            {
                this.delta = 0;
                bariaswitch = 1;
                playerBullet.shieldImage = 1;
                playerBullet.shieldHp = 3;
            }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBullet : MonoBehaviour {
    //プレイヤーが出す弾飛ばし
  
    float Buletspeed = 0.13f;  //弾の速度
    public static int shieldHp=3;   //バリアの耐久値
    public static int shieldImage = 1;  //バリアの画像取得と当たり判定切り替え
    GameObject bariaImage1_switch;  //バリア１の画像
    GameObject bariaImage2_switch;  //バリア２の画像
    GameObject bariaImage3_switch;  //バリア３の画像

    GameObject bariaPrehub;

    
    // Use this for initialization
    void Start () {
        
        bariaPrehub = GameObject.Find("bariaGenertor");
       
    }

    // Update is called once per frame
    void Update()
    {
        if (shieldImage == 1)   //バリア１の画像
        {
            bariaImage1_switch = this.bariaPrehub.GetComponent<shieldForm>().baria1;
        }
        if (shieldImage == 2)   //バリア２の画像
        {
            bariaImage2_switch = this.bariaPrehub.GetComponent<shieldForm>().baria2;
        }
        if(shieldImage == 3)    //バリア３の画像
        {
            bariaImage3_switch = this.bariaPrehub.GetComponent<shieldForm>().baria3;
        }
        transform.Translate(Buletspeed, 0, 0);

        if (transform.position.x > 5.0f)
        {
            Destroy(gameObject);
        }
        if (shieldImage!=0) //位置情報取得
        {
            Vector2 p1 = transform.position;
            Vector2 p2 =  this.bariaPrehub.transform.position;
            Vector2 dir = p1 - p2;
            float d = dir.magnitude;
            float r1 = 0.3f;
            float r2 = 1.0f;

            if (d < r1 + r2)    //バリアにあたった場合
            {
                if (shieldHp==3)    //バリアに当たってかつバリアのHPが３の時
                {
                    shieldHp--;
                    Debug.Log("バリアのHP"+shieldHp);
                    Destroy(gameObject);
                    
                    Destroy(bariaImage1_switch);
                    shieldImage = 2;
                    shieldForm.bariaswitch = 2;
             

                 }
                else if(shieldHp==2)    //バリアに当たってかつバリアのHPが２の時
                {
                    
                    shieldHp--;
                    Debug.Log("バリアのHP"+shieldHp);
                    Destroy(gameObject);
                    Destroy(bariaImage2_switch);
                    shieldForm.bariaswitch = 3;
                    shieldImage = 3;
                }
                else if (shieldHp == 1)  //バリアに当たってかつバリアのHPが１の時
                {
                    shieldHp--;
                    Debug.Log("バリアのHP"+shieldHp);
                    Destroy(gameObject);
                    Destroy(bariaImage3_switch);   
                    shieldForm.bariaswitch = 0;// バリア残機がない
                    shieldImage = 0;
                }

            }
        }
    }
}

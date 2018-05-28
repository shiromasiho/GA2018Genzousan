using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//弾飛ばし&当たり判定
public class Bulletstrike : MonoBehaviour {

    float Buletspeed = -0.13f;  //弾の速度
    static int playerhp = 1;    //プレイヤー残機(アーマー着用数)
    static int playerP = 1; //プレイヤー表記管理変数
    GameObject player;
   

    // Use this for initialization
    void Start () {
        this.player = GameObject.Find("player");
       
    }
	
	// Update is called once per frame
	void Update () {
      
        transform.Translate(Buletspeed, 0, 0);

        if (transform.position.x < -8.0f)
        {
            Destroy(gameObject);    //弾が画面外にいくと弾を消す
        }
        if (playerP == 1)
        {
            //あたり判定
            Vector2 p1 = transform.position;
            Vector2 p2 = this.player.transform.position;
            Vector2 dir = p1 - p2;
            float d = dir.magnitude;
            float r1 = 0.3f;
            float r2 = 1.0f;

            if (d < r1 + r2)    //プレイヤーと弾が当たった時
            {

                Destroy(gameObject);
                if (playerhp > 0)   //プレイヤー残機がある場合
                {
                    playerhp--;
                    Debug.Log("プレイヤー残機数"+playerhp);
                }
                else
                {
                    Destroy(this.player);   //プレイヤー残機がない場合
                     playerP = 0;
                    
                }
            }
        }
    }
}

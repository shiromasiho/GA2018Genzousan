using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{

    GameObject tenguplayer;
    //private AudioSource DamageSe;           // ダメージSE

    void Start()
    {
        this.tenguplayer = GameObject.Find("tenguplayer");
        //AudioSource[] audioSources = GetComponents<AudioSource>();
        //DamageSe = audioSources[0];        
    }

    // Update is called once per frame
    void Update()
    {
        //飛んでくるやで
        transform.Translate(-0.1f, 0, 0);

        //画面外に出たら破棄
        if (transform.position.x < 10.5f)
        {
            Destroy(gameObject);
        }

        ////当たり判定範囲
        //Vector2 p1 = transform.position;    //矢の中心座標
        //Vector2 p2 = this.tenguplayer.transform.position;    //プレイヤーの中心座標
        //Vector2 dir = p1 - p2;
        //float d = dir.magnitude;
        //float r1 = 0.5f;    //矢の半径
        //float r2 = 1.0f;    //プレイヤー半径

        //if (d < r1 + r2)
        //{
        //    Destroy(gameObject);
        //    //当たると矢が消える
        //}
    }
        //当たり判定
        private void OnCollisionEnter2D(Collision2D collision)
          {
            //DamageSe.PlayOneShot(DamageSe.clip);                    // 音鳴らす
              Debug.Log("当たったで");
              Destroy(gameObject);
          }
   }



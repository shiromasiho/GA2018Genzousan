using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyBullet : MonoBehaviour {

	// Use this for initialization
    GameObject player;
    public GameObject wasi;
    GameObject gamemaindirector;    //変数呼ぶんご
    GameMainDirector maindirector;

    PEquipment equipment;


    void Start()
    {
        this.player = GameObject.Find("player");

        
    }

    // Update is called once per frame
    void Update()
    {
        //飛んでくるやで
        transform.Translate(-0.1f, 0, 0);

        //画面外に出たら破棄
        if (transform.position.x < -8.0f)
        {
            Destroy(gameObject);
        }

	}
    //全員消す
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "player")
        {
            if(GameMainDirector.playerHp > 0){
            GameMainDirector.playerHp = GameMainDirector.playerHp--;  //死ぬやで
            PEquipment.Equipment_flg = 1;//装備飛んだ
            Destroy(wasi);
            Debug.Log("プレイヤー残機数" + GameMainDirector.playerHp);
           }else{
                GameMainDirector.playerHp =0;
                Debug.Log("プレイヤー残機数" + GameMainDirector.playerHp);
           }
        }
        if (collision.gameObject.tag == "fire")
        {
            Destroy(wasi);
        }
    }
}

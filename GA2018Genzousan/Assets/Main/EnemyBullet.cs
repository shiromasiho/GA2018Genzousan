using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyBullet : MonoBehaviour {

	// Use this for initialization
    GameObject player;
    public GameObject wasi;
    GameObject gamemaindirector;    //変数呼ぶんご
    GameMainDirector maindirector;


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
          //   GameMainDirector.playerHp = GameMainDirector.playerHp -1;  //死ぬやで
            Destroy(wasi);
        }
        if (collision.gameObject.tag == "fire")
        {
            Destroy(wasi);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICBox : MonoBehaviour {

    // Use this for initialization
    GameObject player;

    GameObject gamemaindirector;    //変数呼ぶんご
    GameMainDirector maindirector;

    public static int GetICflg;    //ICスキルをゲットした時のflg
    public static int ICflg;      //ICのスキル(randam)

    void Start()
    {
        this.player = GameObject.Find("player");
        GetICflg = 0;
        ICflg = 0;

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
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            ICBox.GetICflg = 1;
            DamageM.ICF = 1;
       //     Debug.Log("とったで工藤");
        }
        Destroy(gameObject);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour {
    public GameObject taka;
    void Start()
    {
        Vector2 tmp = GameObject.Find("player").transform.position;  //プレイヤーの位置情報取得
        float x = tmp.x + 1.5f;
        float y = tmp.y + 0.15f;
        transform.position = new Vector3(x, y, 0); //playerfirePrefabをplayerの横に出るように位置情報書き換え
    }

    // Update is called once per frame
    void Update()
    {
        //飛ばす
        transform.Translate(0.1f, 0, 0);

        //破棄
        if (transform.position.x > 2.0f){
            Destroy(gameObject);
            ShieldControl.BF--;
        }

    }
    //全員消す
     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "fire")
        {
            Destroy(taka);
        }
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(taka);
        }
    }
}

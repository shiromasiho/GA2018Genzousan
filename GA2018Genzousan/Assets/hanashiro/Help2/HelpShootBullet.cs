using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpShootBullet : MonoBehaviour {
   

    void Start()
    {
     
      Vector2 tmp = GameObject.Find("tenguplayer").transform.position;  //プレイヤーの位置情報取得
        float x = tmp.x + 1.5f;
        float y = tmp.y + 0.15f;
        transform.position = new Vector3(x,  y, 0); //playerfirePrefabをplayerの横に出るように位置情報書き換え
     
    }

    // Update is called once per frame
    void Update()
    {
       
        //飛ばす
        transform.Translate(0.1f, 0, 0);
        //画面外に出たら破棄
        //if (transform.position.x > 30.5f){
        //    Destroy(gameObject);
        //}

      
    }
}

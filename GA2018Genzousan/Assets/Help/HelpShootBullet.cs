using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpShootBullet : MonoBehaviour {

    GameObject tenguplayer;
    void Start()
    {
        this.tenguplayer = GameObject.Find("tenguplayer");    //追加
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y = -3;
        //pos = this.tenguplayer.transform.position;
        transform.position = pos;

        //飛ばす
        transform.Translate(0.1f, 0, 0);


        //画面外に出たら破棄
        if (transform.position.x > 30.5f){
            Destroy(gameObject);
        }

      
    }
}

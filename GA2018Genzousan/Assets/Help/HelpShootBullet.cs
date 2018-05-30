using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpShootBullet : MonoBehaviour {

    void Start()
    {
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

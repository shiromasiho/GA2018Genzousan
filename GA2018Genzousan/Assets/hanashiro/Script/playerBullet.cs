using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBullet : MonoBehaviour {
    //プレイヤーが出す弾飛ばし

    float Buletspeed = 0.13f;  //弾の速度
    static int shieldHp=3;
    static int shieldS = 1;
    
    GameObject shieldPrehub;
                                // Use this for initialization
    void Start () {
        this.shieldPrehub = GameObject.Find("shieldPrehub");
    }

    // Update is called once per frame
    void Update()
    {
        
          
        transform.Translate(Buletspeed, 0, 0);

        if (transform.position.x > 5.0f)
        {
            Destroy(gameObject);
        }
        if (shieldS == 1)
        {
            Vector2 p1 = transform.position;
            Vector2 p2 = this.shieldPrehub.transform.position;
            Vector2 dir = p1 - p2;
            float d = dir.magnitude;
            float r1 = 0.3f;
            float r2 = 1.0f;

            if (d < r1 + r2)    //シールドにあたった場合
            {
                shieldHp--;
                Debug.Log(shieldHp);
                Destroy(gameObject);
            }
        }
    }
}

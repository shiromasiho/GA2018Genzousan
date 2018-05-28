using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlletForm : MonoBehaviour {
    //プレイヤーが出す弾の生成

    public GameObject Car2Prehub;
  
    static int PlayerBulletswitch = 1;   //弾を生成する変数
                                   // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (PlayerBulletswitch ==1&& Input.GetMouseButtonDown(0))   //左クリックされた場合に弾を生成する
        {
          
         GameObject go = Instantiate(Car2Prehub) as GameObject;
         
            
        }
    }
}

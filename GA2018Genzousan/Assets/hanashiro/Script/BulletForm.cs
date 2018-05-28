using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//弾生成
public class BulletForm : MonoBehaviour {

    public GameObject BulletPrehub;
    float Formspeed = 2.0f; //弾が生成される間隔時間
    float Formdelta = 0;
    static int Bulletswitch = 1;   //弾を生成する変数
    
    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        this.Formdelta += Time.deltaTime;
        if (Bulletswitch==1 && this.Formdelta > Formspeed)
        {
            this.Formdelta = 0;
            GameObject go = Instantiate(BulletPrehub) as GameObject;
            int py = Random.Range(-3, 4);
            go.transform.position = new Vector3(4, py, 0);  // Y座標をランダムにして弾を出す
        }

    }
}

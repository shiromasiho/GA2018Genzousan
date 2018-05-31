using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGenerator : MonoBehaviour {

    public GameObject firePrefab;
    float span = 4.0f;
    float delta = 0;
    public GameObject go;
    public GameObject playerfirefab;
    public GameObject go2;
    public static int Pfireflg = 0;
	// Update is called once per frame
    void Update(){
        //弾生成
        this.delta += Time.deltaTime;
        if(this.delta > this.span){ //エネミーファイア
            this.delta =0;
             go = Instantiate(firePrefab) as GameObject;
           // int px = Random.Range(-3, 4);
            go.transform.position = new Vector3(20,-3,0); //炎の位置
        }


        if (Pfireflg == 1)  //プレイヤーファイア
        { 
            go2 = Instantiate(playerfirefab) as GameObject;
            Pfireflg = 0;

        }

	}
}

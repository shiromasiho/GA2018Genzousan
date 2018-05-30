using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGenerator : MonoBehaviour {

    public GameObject firePrefab;
    float firespan = 4.0f;
    float delta = 0;
	
	// Update is called once per frame
    void Update(){
        //弾生成
        this.delta += Time.deltaTime;
        if(this.delta > this.firespan){
            this.delta =0;
            GameObject go = Instantiate(firePrefab) as GameObject;
           // int px = Random.Range(-3, 4);
            go.transform.position = new Vector3(20,-3,0); //炎の位置
            }
	}
}

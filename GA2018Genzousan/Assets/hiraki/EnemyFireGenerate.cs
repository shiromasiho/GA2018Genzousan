using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireGenerate : MonoBehaviour
{

    public GameObject firePrefab;
    float span = 2.5f;
    float delta = 0;
    public static int GeneFlg = 1;       // 弾生成フラグ

    void Update()
    {
        if(GeneFlg == 1)
        {
            //弾生成
            this.delta += Time.deltaTime;
            if (this.delta > this.span)
            {
                this.delta = 0;
                GameObject go = Instantiate(firePrefab) as GameObject;
                int px = Random.Range(-4, 0);
                go.transform.position = new Vector3(2, px, 0);
            }
        }
    }
}

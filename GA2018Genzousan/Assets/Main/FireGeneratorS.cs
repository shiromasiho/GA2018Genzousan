using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGeneratorS : MonoBehaviour {

    private AudioSource EFMS;           // 敵の弾SE
    public GameObject firePrefab;
    float span;
    float delta;
    public GameObject go;
    public GameObject playerfirefab;
    public GameObject go2;
    public static int Pfireflg = 0;
    public static int GeneFlg = 1; //弾の生成フラグ

    public GameObject ICPrefab;
    float span2;
    float delta2;
    public GameObject ICgo;
    public static int ICfireflg;    //IC
    public static int GeneFlg2;

    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        EFMS = audioSources[0];

        span = 2.0f;
        delta = 0;
        Pfireflg = 0;
        GeneFlg = 1; //弾の生成フラグ

        span2 = 7.0f;
        delta2 = 0;
        ICfireflg = 0;
        GeneFlg2 = 1; //弾の生成フラグ
    }


    // Update is called once per frame
    void Update()
    {
        if (GeneFlg == 1)
        {
            //弾生成
            this.delta += Time.deltaTime;
            if (this.delta > this.span)
            { //エネミーファイア
                EFMS.PlayOneShot(EFMS.clip);                    // 音鳴らす
                this.delta = 0;
                go = Instantiate(firePrefab) as GameObject;

                float py = Random.Range(-2, -5);
                go.transform.position = new Vector3(1, py, 0); //炎の位置
                

            }
            if (Pfireflg == 1)  //プレイヤーファイア
            {
                go2 = Instantiate(playerfirefab) as GameObject;
                Pfireflg = 0;

            }
        }
        if (GeneFlg2 == 1)
        {
            //IC
            this.delta2 += Time.deltaTime;
            if (this.delta2 > this.span2)
            {
                this.delta2 = 0;
                ICgo = Instantiate(ICPrefab) as GameObject;

                int py2 = Random.Range(-2, -4);
                ICgo.transform.position = new Vector3(0, py2, 0); //ICの位置
            }
        }


    }
}

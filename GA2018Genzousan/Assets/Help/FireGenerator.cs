using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGenerator : MonoBehaviour {


    public GameObject firePrefab;
    private AudioSource EnemyFireSe;           // 敵の弾SE
    float span = 4.0f;
    float delta = 0;
    public GameObject go;
    public GameObject playerfirefab;
    public GameObject go2;
    public static int Pfireflg = 0;
    // Update is called once per frame

    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        EnemyFireSe = audioSources[0];
    }
    
    void Update()
    {
        //弾生成

        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        { //エネミーファイア
            EnemyFireSe.PlayOneShot(EnemyFireSe.clip);                    // 音鳴らす
            this.delta = 0;
            go = Instantiate(firePrefab) as GameObject;
            // int px = Random.Range(-3, 4);
            go.transform.position = new Vector3(16, -4, 0); //炎の位置
        }


        if (Pfireflg == 1)  //プレイヤーファイア
        {
            go2 = Instantiate(playerfirefab) as GameObject;
            Pfireflg = 0;

        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockShoot : MonoBehaviour {

    private AudioSource CatchSe;            // キャッチSE
    private AudioSource ReverseSe;          // 跳ね返しSE
    public int bulletflg;
    public GameObject stockbullet;
    public GameObject playerbullet;
    GameObject stock;

 //   public static int stockflg = 1; //連射フラグ

    // Use this for initialization
    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        CatchSe   = audioSources[0];
        ReverseSe = audioSources[1];
        bulletflg = 1;
        stock = GameObject.Find("FireGenerator");
    }

    // Update is called once per frame
    void Update()
    {
        stockbullet = this.stock.GetComponent<FireGenerator>().go;
        if (Input.GetKeyDown("x") && bulletflg == 1)  //shoot
        {
            Instantiate(playerbullet);
            FireGenerator.Pfireflg = 1;
    //       GameObject obj = Instantiate(playerbullet) as GameObject;
            bulletflg = 0;
            ReverseSe.PlayOneShot(ReverseSe.clip);
            Debug.Log("弾丸にゃ");
            Debug.Log("hokan" + bulletflg);
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKey("z") && bulletflg == 0)    //stock
        {
            if (other.tag == "tama")
            {
                Debug.Log("撃たれてんじゃねぇか！！！");
                CatchSe.PlayOneShot(CatchSe.clip);
                Destroy(stockbullet);
                bulletflg = 1;
            }
        }
    }
}

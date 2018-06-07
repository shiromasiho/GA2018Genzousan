using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStockShoot : MonoBehaviour {

    public int bulletflg;
    public GameObject stockbullet;
    public GameObject playerbullet;
    GameObject stock;

    public static int stockflg;    //stockflg (弾連射）

    // Use this for initialization
    void Start()
    {
        stockflg = 1;
        bulletflg = 1;
        stock = GameObject.Find("FireGenerator");
    }

    // Update is called once per frame
    void Update()
    {
        stockbullet = this.stock.GetComponent<FireGeneratorS>().go;
        if (Input.GetKeyDown("x") && bulletflg == 1)  //shoot
        {
            Instantiate(playerbullet);
            FireGeneratorS.Pfireflg = 1;
            //       GameObject obj = Instantiate(playerbullet) as GameObject;
            bulletflg = 0;
            Debug.Log("弾丸にゃ");
            Debug.Log("hokan" + bulletflg);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (Input.GetKeyDown("z") && bulletflg == 0 && stockflg==0)    //stock
        {
            if (other.tag == "tama")
            {
                Debug.Log("撃たれてんじゃねぇか！！！");
                Destroy(stockbullet);
                bulletflg = 1;
            }
        }
        else if (Input.GetKeyDown("z") && stockflg == 1)    //連射フラグが立っている場合のストック処理（１つのストックの時でも打てる）
        {
            if (other.tag == "tama")
            {

                bulletflg++;
                Debug.Log("撃たれてんじゃねぇかyo！！！" + bulletflg);
                Destroy(stockbullet);
            }
        }
    }
}

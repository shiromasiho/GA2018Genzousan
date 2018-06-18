using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStockShoot : MonoBehaviour {

    public int bulletflg;
    public GameObject stockbullet;
    public GameObject playerbullet;
    GameObject stock;
    public static int stockImgflg;

    public static int GetEquipmentflg = 0;    //装備をゲットした時のflg
    // Use this for initialization
    void Start()
    {
        bulletflg = 1;
        stock = GameObject.Find("FireGenerator");
    }

    // Update is called once per frame
    void Update()
    {
        stockbullet = this.stock.GetComponent<FireGeneratorS>().go;
        if (Input.GetKeyDown("x") && bulletflg !=0)  //shoot
        {
            Instantiate(playerbullet);
            FireGeneratorS.Pfireflg = 1;
            //       GameObject obj = Instantiate(playerbullet) as GameObject;
            bulletflg--;
            Debug.Log("弾丸にゃ");
            stockImgflg = 1;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {

        if (Input.GetKeyDown("z") && bulletflg == 0) //&& skillMng.stockpulsskill == 2)    //stock
        {
            if (other.tag == "fire")
            {
                Debug.Log("撃たれてんじゃねぇか！！！");
                Destroy(stockbullet);
                bulletflg = 1;
                stockImgflg = 0;
            }
            if(other.tag =="enemy")
            {
                Debug.Log("くたばれ！！");
                PlayerStockShoot.GetEquipmentflg = 1;
                Debug.Log("HP" + GameMainDirector.enemyHp);

                if (skillMng.Continuous_shootingskill == 2)
                {
                    GameMainDirector.enemyHp = GameMainDirector.enemyHp - 3;
                }
                else
                {
                    GameMainDirector.enemyHp--;
                }
            }
        }
        else if (Input.GetKeyDown("z") && skillMng.stockpulsskill == 2)    //連射フラグが立っている場合のストック処理（１つのストックの時でも打てる）
        {
            if (other.tag == "fire")
            {

                bulletflg =2;
                Debug.Log("撃たれてんじゃねぇかyo！！！" + bulletflg);
                Destroy(stockbullet);
            }
        }
    }
}

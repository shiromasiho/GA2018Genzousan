using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockShoot : MonoBehaviour {

    static int bulletflg=0;
    public GameObject stockbullet;
    public GameObject playerbullet;
    GameObject stock;
    // Use this for initialization
    public static int stockflg = 1; //連射フラグ

    void Start()
    {
        stock = GameObject.Find("FireGenerator");
       
    }

    // Update is called once per frame
    void Update()
    {
        stockbullet =this.stock.GetComponent<FireGenerator>().go;
        if (Input.GetKeyDown("x") && bulletflg!=0)  //shoot
        {
            Debug.Log("弾丸にゃ");
            FireGenerator.Pfireflg = 1;
            bulletflg--;
            Debug.Log("hokan" + bulletflg);
            
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown("z") && bulletflg == 0&&stockflg==0)    //stock連射フラグが立っていないとき

        {
            if (other.tag == "tama")
            {
               
                Debug.Log("撃たれてんじゃねぇか！！！");
                Destroy(stockbullet);
                bulletflg = 1;
              
            }

        }
        else if (Input.GetKeyDown("z") &&stockflg==1)    //連射フラグが立っている場合のストック処理（１つのストックの時でも打てる）
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

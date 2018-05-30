using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockShoot : MonoBehaviour {

    public int bulletflg;
    public GameObject stockbullet;
    public GameObject playerbullet;
    // Use this for initialization
    void Start()
    {
        bulletflg = 0;
        //GameObject newStockbullet = (GameObject)Instantiate(stockbullet);
        //newStockbullet.name = stockbullet.name;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("x") && bulletflg == 1)  //shoot
        {
            Debug.Log("弾丸にゃ");
            Instantiate(playerbullet);
           GameObject obj = Instantiate(playerbullet) as GameObject;
            bulletflg = 0;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (Input.GetKeyDown("z") && bulletflg == 0)    //stock
        {
            if (other.tag == "tama")
            {
                Debug.Log("撃たれてんじゃねぇか！！！");
                Destroy(stockbullet);
                bulletflg = 1;
            }
        }
    }
}

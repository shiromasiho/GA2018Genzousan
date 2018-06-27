using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStockShoot : MonoBehaviour
{
    SpriteRenderer MainSpriteRenderer;

    private AudioSource DamageSE;          //敵のダメージ時SE
    private AudioSource CatchS;            // キャッチSE
    private AudioSource ReverseS;          // 跳ね返しSE
    public int bulletflg;
    public GameObject stockbullet;
    public GameObject playerbullet;
    GameObject stock;
    public static int stockImgflg;

    public static int GetEquipmentflg;    //装備をゲットした時のflg
    public static bool FlashFlg;
    // Use this for initialization
    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        CatchS = audioSources[0];
        ReverseS = audioSources[1];
    //    DamageSE = audioSources[2]; //こいついる弾でないから消しとく
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        bulletflg = 1;
        stock = GameObject.Find("FireGenerator");
        GetEquipmentflg = 0;
        FlashFlg = false;
    }

    // Update is called once per frame
    void Update()
    {
        stockbullet = this.stock.GetComponent<FireGeneratorS>().go;
        if (Input.GetKeyDown("x") && bulletflg != 0)  //shoot
        {
            Instantiate(playerbullet);
            FireGeneratorS.Pfireflg = 1;
            //       GameObject obj = Instantiate(playerbullet) as GameObject;
            bulletflg--;
            ReverseS.PlayOneShot(ReverseS.clip);        // 跳ね返しSE
            Debug.Log("弾丸にゃ");
            stockImgflg = 1;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {


        if (Input.GetKeyDown("z") && skillMng.stockpulsskill == 2)
        {
            if (other.tag == "fire")
            {

                bulletflg = 2;
                Debug.Log("撃たれてんじゃねぇかyo！！！" + bulletflg);
                Destroy(stockbullet);
            }
            if (other.tag == "enemy")
            {
                Debug.Log("くたばれ！！");
                PlayerStockShoot.GetEquipmentflg = 1;
                Debug.Log("HP" + GameMainDirector.enemyHp);
                if (skillMng.Continuous_shootingskill == 2)
                {
                    GameMainDirector.enemyHp = GameMainDirector.enemyHp - 3;
                 //   DamageSE.PlayOneShot(DamageSE.clip);
                    FlashFlg = true;
                }
                else
                {
                    GameMainDirector.enemyHp--;
                    DamageSE.PlayOneShot(DamageSE.clip);
                    FlashFlg = true;
                }
            }

        }
        else if (Input.GetKeyDown("z")) //&& skillMng.stockpulsskill == 2)    //stock
        {
            if (other.tag == "fire")
            {
                Debug.Log("撃たれてんじゃねぇか！！！");
                CatchS.PlayOneShot(CatchS.clip);        // 吸収SE
                Destroy(stockbullet);
                bulletflg = 1;
                stockImgflg = 0;
            }
            if (other.tag == "enemy")
            {
                Debug.Log("くたばれ！！");
                PlayerStockShoot.GetEquipmentflg = 1;
                Debug.Log("HP" + GameMainDirector.enemyHp);

                if (skillMng.Continuous_shootingskill == 2)
                {
                    GameMainDirector.enemyHp = GameMainDirector.enemyHp - 3;
                    DamageSE.PlayOneShot(DamageSE.clip);
                    FlashFlg = true;
                }
                else
                {
                    GameMainDirector.enemyHp--;
                    DamageSE.PlayOneShot(DamageSE.clip);
                    FlashFlg = true;
                }
            }
        }
    }
}

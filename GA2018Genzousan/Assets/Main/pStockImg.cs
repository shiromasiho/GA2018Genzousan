using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pStockImg : MonoBehaviour {


    SpriteRenderer MainSpriteRenderer;
    public Sprite stockImg;//fireImg

    // Use this for initialization
    void Start()
    {

        //gameObject.SetActive(false);
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        MainSpriteRenderer.sprite = null;
    }

    // Update is called once per frame
    void Update()
    {
      //  if (Input.GetKey("z")) 
       if (PlayerStockShoot.stockImgflg == 0)    //連射フラグが立っている場合のストック処理（１つのストックの時でも打てる）
        {
            MainSpriteRenderer.sprite = stockImg;
            Debug.Log("うつれや");
        }
        else
        {
            MainSpriteRenderer.sprite = null;
        }   //消した

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class film : MonoBehaviour {

    public GameObject playarfire;
    public StockShoot stockshoot;
    
    int filmflg;
    Image flimImg;
    public Sprite flim_Sprite;
	// Use this for initialization
	void Start () {
        filmflg = stockshoot.bulletflg;
        flimImg = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("x") && filmflg ==1)  //shoot
        {
         //   GameObject obj =Instantiate(playarfire)as GameObject;
            flimImg.sprite = flim_Sprite;
            filmflg = 0;
        }

        if (Input.GetKeyDown("z") && filmflg ==0)    //stock
        {
            Destroy(flim_Sprite);
            filmflg = 1;
        }
	}
}

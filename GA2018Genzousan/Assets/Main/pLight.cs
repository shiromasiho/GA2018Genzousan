using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pLight : MonoBehaviour {
    
    SpriteRenderer MainSpriteRenderer;
    public Sprite stocklight;//ライト

	// Use this for initialization
	void Start () {
		
         //gameObject.SetActive(false);
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        MainSpriteRenderer.sprite = null;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("z"))    //連射フラグが立っている場合のストック処理（１つのストックの時でも打てる）
        {
            MainSpriteRenderer.sprite = stocklight;
        }
        else { MainSpriteRenderer.sprite = null; 
        }   //消した
	}
}

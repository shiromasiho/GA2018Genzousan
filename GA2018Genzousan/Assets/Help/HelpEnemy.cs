using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpEnemy : MonoBehaviour {
    SpriteRenderer MainSpriteRenderer;
    public Sprite enemyImg;//fireImg

	// Use this for initialization
	void Start () {
        //gameObject.SetActive(false);
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        MainSpriteRenderer.sprite = null;
	}
	
	// Update is called once per frame
    void Update()
    {
    }
     //     if (Input.GetKey("z")) 
    void OnCollisionEnter2D(Collision2D collision)
    {
     //   if (gameObject.tag == "fire")
    //    {
     //       MainSpriteRenderer.sprite = null;
    //    }else{
            MainSpriteRenderer.sprite = enemyImg;
    //    }   //消した
     }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hellotama : MonoBehaviour {

    int bulletflg;
    public GameObject tama;
    public GameObject bullet;
	// Use this for initialization
	void Start () {
        bulletflg = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("a")&&bulletflg == 1)
        {
            Debug.Log("弾丸にゃ");
            Instantiate(bullet);
            bulletflg = 0;
        }
	}
    void OnTriggerStay2D(Collider2D other)
    {
        if(Input.GetKeyDown("b")&&bulletflg ==0)
        {
            if (other.tag == "tama")
            {
            Debug.Log("撃たれてんじゃねぇか！！！");
            Destroy(tama);
            bulletflg = 1;
            }
        }
    }
}

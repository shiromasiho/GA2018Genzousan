using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boost : MonoBehaviour {

    Rigidbody2D rigid2D;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 5.0f;
    float BSpeed = 0;

	// Use this for initialization
	void Start () {
        this.rigid2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //ジャンプする
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        //左右移動
        int LRkey = 0;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            LRkey = 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            LRkey = -1;
        }
        int UDkey = 0;
        if(Input.GetKey(KeyCode.UpArrow))
        {
            UDkey = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            UDkey = -1;
        }

        //ブースト移動
        if (Input.GetKeyDown(KeyCode.Z))
        {
            BSpeed = 1.0f;    
        }

        //プレイヤの速度
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);
        float speedy = Mathf.Abs(this.rigid2D.velocity.y);
        //スピード制限
        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * LRkey * this.walkForce);
        }
        if (speedy < this.maxWalkSpeed)
        {
       //     this.rigid2D.AddForce(transform.up * UDkey * this.walkForce);
        }

        transform.Translate(this.BSpeed * LRkey, this.BSpeed * UDkey, 0);
        this.BSpeed *= 0.78f;
        if (LRkey == 0 && UDkey == 0)
        {
            this.rigid2D.velocity = Vector2.zero;
        }
    }

}


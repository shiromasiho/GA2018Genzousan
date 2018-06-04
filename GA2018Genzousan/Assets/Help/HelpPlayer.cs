using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpPlayer : MonoBehaviour {

    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;

    //public GameObject playarfire;

	// Use this for initialization
	void Start () {
        this.rigid2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
       // ジャンプ 
        if (Input.GetKeyDown(KeyCode.UpArrow) &&
            this.rigid2D.velocity.y == 0){
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        //移動 
        int Key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) Key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) Key = -1;

        //プレイヤー速度
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        //スピード制限
        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * Key * this.walkForce);
        }

	}
}

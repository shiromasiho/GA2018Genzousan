using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    GameObject player;

        Rigidbody2D rigid2D;
        Animator animator;
        float jumpForce = 680.0f;
        float walkForce = 30.0f;
        float maxWalkSpeed = 2.0f;

        float Ground = 0.0f;
        float jumpKey = 0;


    void Start(){
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //ジャンプ
        Ground = transform.position.y;

        if ((jumpKey == 1) && (Ground <= -3.7)) jumpKey = 0;

        if ((Input.GetKeyDown(KeyCode.UpArrow)) && (jumpKey == 0))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
            jumpKey = 1;
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

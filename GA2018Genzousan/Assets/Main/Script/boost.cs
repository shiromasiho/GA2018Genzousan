using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boost : MonoBehaviour {
    Rigidbody2D rigid2D;
    float jumpForce = 680.0f;
    float walkForce = 36.0f;
    float maxWalkSpeed = 2.0f;

	// Use this for initialization
	void Start () {
        this.rigid2D = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update() {
        //ジャンプする
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        //左右移動
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        //プレイヤの速度
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        //スピード
        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }
	}
}

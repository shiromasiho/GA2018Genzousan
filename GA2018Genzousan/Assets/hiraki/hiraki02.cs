using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiraki02 : MonoBehaviour {

        Rigidbody2D rigid2D;
        Animator animator;
        float jumpForce = 400.0f;
        float Ground = 0.0f;
        int JumpKey = 0;

	// Use this for initialization
	void Start () {

        this.rigid2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        //ジャンプ 
        Ground = transform.position.y;

        if ((JumpKey == 1) && (Ground <= -3.7)) JumpKey = 0;

        if ((Input.GetKeyDown(KeyCode.UpArrow)) && (JumpKey == 0))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
            JumpKey = 1;
        }
	
	}
}

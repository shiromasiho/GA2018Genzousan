using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiraki : MonoBehaviour
{

    Rigidbody2D rigid2D;
    Animator animator;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        int Key = 0;

        //移動 
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

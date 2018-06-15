using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

     public GameObject player;
        SpriteRenderer MainSpriteRenderer;
        Rigidbody2D rigid2D;
        Animator animator;
        float jumpForce = 400.0f;
        float walkForce = 30.0f;
        float maxWalkSpeed = 2.0f;

        float Ground = 0.0f;
        float jumpKey = 0;

        public static int playerskill = 0;
        public Sprite playerImg;
        public Sprite playerImg2;

    void Start(){
        this.rigid2D = GetComponent<Rigidbody2D>();
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            playerskill = 1;
             if (playerskill == 1)
            {
            MainSpriteRenderer.sprite = playerImg2;   //変わるんご
              }else{
            MainSpriteRenderer.sprite = playerImg;
           }
        }

            //ジャンプ
            Ground = transform.position.y;

            if ((jumpKey == 1) && (Ground <= -3.7)) jumpKey = 0;
           
                if (Input.GetKeyDown(KeyCode.UpArrow) && jumpKey == 0)// &&skillMng.Bustskill ==2)
                {
                    if (this.rigid2D.velocity.y == 0)
                    {
                        Debug.Log("謀反まんだぁぁぁ！！");
                        this.rigid2D.AddForce(transform.up * (this.jumpForce * skillMng.jumpskill));//skill
                        jumpKey = 1;
                    }
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

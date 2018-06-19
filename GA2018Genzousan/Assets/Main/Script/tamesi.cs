using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tamesi : MonoBehaviour {
    //定数
    public const int btlg = 10; //燃料
    public const float btsp = 20.0f; //Boost速度
    public float speedRunner = 2.0f; //移動速度
    public float time = 4.0f; 
    public float cooltime = 1.0f; //クールタイムの秒数

    //変数    
    public float count = 0; //クールタイム初期化
    private Vector3 moveDirection = Vector3.zero;
    public bool boost = true; //ブーストflag
    public int key; //左右移動
    public int sco; //燃料タンク
    public int jmp;
    Rigidbody2D hover;

    void Start()
    {
        hover = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        ////秒数カウント
        //if (count > 0)
        //{
        //    boost = false;
        //    count -= Time.deltaTime;
        //    Debug.Log(count);
        //}
        //else
        //{
        //    boost = true;
        //}

        //ジャンプ
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            jmp = 10;
        }
        if (jmp != 0)
        {
            transform.position += (Vector3.up * 30.0f * Time.deltaTime);
            jmp--;
        }

        //ブースト・ホバー
        if(Input.GetKey(KeyCode.Space))
        {
            transform.position +=(Vector3.up * 30.0f * Time.deltaTime);
            hover.gravityScale = 0;
        }
        if (hover.gravityScale == 0)
        {
            transform.position += (Vector3.down * 1.7f * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            hover.gravityScale = 3;
        }


        //プレイヤー移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speedRunner * Time.deltaTime;
            key = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speedRunner * Time.deltaTime;
            key = 1;
        }
        if (Input.GetKeyDown(KeyCode.Z) /*&& boost == true*/)
        {
            sco =btlg;
            //count = cooltime;
        }
        if(sco != 0)
        {
            transform.position += (Vector3.right * btsp * Time.deltaTime) * key;
            sco--;
        }

        // 移動制限
        Clamp();
    }

    void Clamp()　//移動制限
    {
        // 画面左下のワールド座標をビューポートから取得
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        // 画面右上のワールド座標をビューポートから取得
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        // プレイヤーの座標を取得
        Vector2 pos = transform.position;

        // プレイヤーの位置が画面内に収まるように制限をかける
        pos.x = Mathf.Clamp(pos.x, min.x+1, max.x-1);
        pos.y = Mathf.Clamp(pos.y, min.y, max.y);

        // 制限をかけた値をプレイヤーの位置とする
        transform.position = pos;
    }

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    hover.gravityScale = 3;
    //}
}

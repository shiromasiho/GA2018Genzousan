using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skillMng : MonoBehaviour {

    SpriteRenderer MainSpriteRenderer;
    // publicで宣言し、inspectorで設定可能にする
    public Sprite DimskillImg;  //暗転機能画像
    int Time = 600;                      // 時間

    public static int jumpskill =1;
    public static int Continuous_shootingskill =1;
	// Use this for initialization
	void Start () {
        //gameObject.SetActive(false);
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        MainSpriteRenderer.sprite = null;
		
	}
	
	// Update is called once per frame
	void Update () {
        //Jump
		  if (PICchip.Jumpflg == 1){
              jumpskill =2;
          }else{
              jumpskill =1;
          }
        //三連射
          if (PICchip.Continuous_shootingflg== 1){
              Continuous_shootingskill = 2;
          }else{
              Continuous_shootingskill = 1;
          }
        //暗転
          if (PICchip.Dimflg == 1){
              MainSpriteRenderer.sprite = DimskillImg;

          }else{
              MainSpriteRenderer.sprite = null;
          }

	}
}

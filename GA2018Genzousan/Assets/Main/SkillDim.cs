using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillDim : MonoBehaviour {

    SpriteRenderer MainSpriteRenderer;

    public Sprite DimskillImg;  //暗転機能画像

    void Start()
    {
        //gameObject.SetActive(false);
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        MainSpriteRenderer.sprite = null;

    }
	
	
	// Update is called once per frame
	void Update () {
        //暗転
        if (PICchip.Dimflg == 1)
        {

            Debug.Log("まっくろくろすけ");
            MainSpriteRenderer.sprite = DimskillImg;

        }
        else
        {
            MainSpriteRenderer.sprite = null;
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldForm : MonoBehaviour {
    //シールド生成
    public GameObject shieldPrehub;
    static int shieldswitch = 1;    //シールド生成管理変数
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (shieldswitch == 1)
        {
            GameObject shield = Instantiate(shieldPrehub) as GameObject;
            shieldswitch = 0;
        }
	}
}

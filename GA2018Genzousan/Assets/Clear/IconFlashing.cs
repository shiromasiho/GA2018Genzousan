using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconFlashing : MonoBehaviour {

    float IconFTime = 90.0f;                    // 点滅時間
	
	void Update () {
        Vector3 pos = transform.position;
        IconFTime--;

        if (IconFTime >= 30) pos.z = 0;         // 表示
         else                pos.z = 1;         // 非表示

        if (IconFTime < 0) IconFTime = 90;

        transform.position = pos;
	}
}

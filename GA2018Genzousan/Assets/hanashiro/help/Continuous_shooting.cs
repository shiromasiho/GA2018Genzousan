using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Continuous_shooting : MonoBehaviour {

    GameObject edge;    //範囲大collider呼び出し

    // Use this for initialization
    void Start () {
        
        edge = GameObject.Find("Continuous_shooting");  //範囲大colliderが入っているobjectを見つける
    
    }
	
	// Update is called once per frame
	void Update () {
        if (PEquipment.Range_Largeflg == 1)  //範囲大フラグが立っているとき
        {
            Debug.Log("世知辛い");
            GetComponent<EdgeCollider2D>().enabled = false; //通常判定をfalse
            edge.GetComponent<EdgeCollider2D>().enabled = true; //範囲大判定をtrue
        }
        //立っていないとき
        else
        {
            
            edge.GetComponent<EdgeCollider2D>().enabled = false;    //通常判定をfalse
            GetComponent<EdgeCollider2D>().enabled = true;  //範囲大判定をtrue

        }
	}
}

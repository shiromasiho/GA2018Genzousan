using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //LoadScene を使うために必要
using UnityEngine.UI;

public class GameMainDirector : MonoBehaviour {

    public static int playerHp;           //体力
    public static int enemyHp;
    GameObject HPmeter;
    // Use this for initialization
    void Start()
    {
        playerHp = 1;
        enemyHp = 60;
        this.HPmeter = GameObject.Find("enemy_hp");
    }
	// Update is called once per frame
	void Update () {
        this.HPmeter.GetComponent<Text>().text = "enemy HP" + enemyHp.ToString();
      //  if (Input.GetKeyDown("a"))
        if (enemyHp <= 0)
        {
            SceneManager.LoadScene("Clear Scene");
        }
     //  if (Input.GetKeyDown("s"))
        if (playerHp <= 0)
        {
            SceneManager.LoadScene("OverScene");
        }
	}
}

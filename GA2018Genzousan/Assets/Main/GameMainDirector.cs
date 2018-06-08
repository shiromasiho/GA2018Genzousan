using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //LoadScene を使うために必要

public class GameMainDirector : MonoBehaviour {

    public static int playerHp;           // バリアの体力
    public static int enemyHp;
    // Use this for initialization
    void Start()
    {
        playerHp = 1;
        enemyHp = 30;
    }
	// Update is called once per frame
	void Update () {
       // if (Input.GetKeyDown("a"))
        if (enemyHp == 0)
        {
            SceneManager.LoadScene("Clear Scene");
        }
       // if (Input.GetKeyDown("s"))
        if (playerHp == 0)
        {
            SceneManager.LoadScene("OverScene");
        }
	}
}

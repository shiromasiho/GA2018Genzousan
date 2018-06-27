using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonSelect : MonoBehaviour {
    int GameMode = 1;
    public string GameScene;
    FadeManager FadeManager;
    // Use this for initialization
    void Start () {
        PEquipment.Equipment_go = 0;
        PEquipment.stockflg = 0;
        PEquipment.Bustflg = 0;

        PlayerStockShoot.stockImgflg = 0;

    }
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKeyDown(KeyCode.RightArrow) && GameMode != 2) {
        //    transform.Translate(250, 0, 0);
        //    GameMode = 2;
        //    Debug.Log(GameMode);
        //}
        //if (Input.GetKeyDown(KeyCode.LeftArrow) && GameMode != 1) {
        //    transform.Translate(-250, 0, 0);
        //    GameMode = 1;
        //    Debug.Log(GameMode);
        //}
        //if (Input.GetKeyDown(KeyCode.Space)) {
        //    ButtonClick();
        //}
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (GameMode == 1 || GameMode == 2)
            {
                transform.Translate(250, 0, 0);
                GameMode++;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (GameMode == 2 || GameMode == 3)
            {
                transform.Translate(-250, 0, 0);
                GameMode--;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ButtonClick();
        }
    }
    public void ButtonClick()
    {

        switch (GameMode)
        {
            case 0:
                FadeManager.namae = "Title Scene";
                FadeManager.Instance.LoadScene("Title Scene", 1.0f);
                break;
            case 1:
                FadeManager.namae = "Main Scene";
                FadeManager.Instance.LoadScene("Main Scene", 1.0f);
                break;
            case 2:
                FadeManager.namae = "Help Scene";
                FadeManager.Instance.LoadScene("Help Scene", 1.0f);
                break;
            case 3:
                FadeManager.namae = "End Scene";
                FadeManager.Instance.LoadScene("End Scene", 1.0f);
                break;
            default:
                break;
        }
    }
}

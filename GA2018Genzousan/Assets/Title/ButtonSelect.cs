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
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.RightArrow) && GameMode != 2) {
            transform.Translate(250, 0, 0);
            GameMode = 2;
            Debug.Log(GameMode);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && GameMode != 1) {
            transform.Translate(-250, 0, 0);
            GameMode = 1;
            Debug.Log(GameMode);
        }
        if (Input.GetKeyDown(KeyCode.Z)) {
            ButtonClick();
        }
	}
    public void ButtonClick()
    {

        switch (GameMode)
        {
            case 0:
                Debug.Log(FadeManager);
                FadeManager.namae = "Title Scene";
                FadeManager.Instance.LoadScene("Title Scene", 1.0f);
                break;
            case 1:
                Debug.Log(FadeManager);
                FadeManager.namae = "Main Scene";
                FadeManager.Instance.LoadScene("Main Scene", 1.0f);
                break;
            case 2:
                FadeManager.namae = "Help Scene";
                FadeManager.Instance.LoadScene("Help Scene", 1.0f);
                break;
            default:
                break;
        }
    }
}

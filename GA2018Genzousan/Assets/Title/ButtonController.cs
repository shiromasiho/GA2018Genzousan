using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public string GameScene;
    FadeManager FadeManager;

    void Start()
    {
        PEquipment.Equipment_go = 0;
        PEquipment.stockflg = 0;
        PEquipment.Bustflg = 0;

        PlayerStockShoot.stockImgflg = 0;

    }

    public void ButtonClick()
    {

        switch (transform.name)
        {
            case "Title Scene":
                Debug.Log(FadeManager);
                FadeManager.namae = "Title Scene";
                FadeManager.Instance.LoadScene("Title Scene", 1.0f);
                break;
            case "Main Scene":
                Debug.Log(FadeManager);
                FadeManager.namae = "Main Scene";
                FadeManager.Instance.LoadScene("Main Scene", 1.0f);
                break;
            case "Help Scene":
                FadeManager.namae = "Help Scene";
                FadeManager.Instance.LoadScene("Help Scene", 1.0f);
                break;
            default:
                break;
        }
    }
}

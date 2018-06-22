using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //シーン遷移に必要

public class StartDirecotr : MonoBehaviour{

    void Start () {
        PEquipment.Equipment_go =0;
        PEquipment.stockflg = 0;
        PEquipment.Bustflg = 0;

        PlayerStockShoot.stockImgflg = 0;

     } 


    public void OnClicked()
    {
        FadeManager.Instance.LoadScene("Main Scene", 1.0f);
    }
}
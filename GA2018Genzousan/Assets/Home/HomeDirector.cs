using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeDirector : MonoBehaviour {

    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("Title Scene");
    }
}

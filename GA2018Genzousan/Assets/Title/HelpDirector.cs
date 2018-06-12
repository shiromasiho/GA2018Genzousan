using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //シーン遷移に必要

public class HelpDirector : MonoBehaviour {

    public void OnClicked()
    {
        FadeManager.Instance.LoadScene("Help Scene", 1.0f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //LoadScene
using UnityEngine.UI;

public class GameHelpDirector : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Title Scene");
        }
    }
    //void OnCollisionEnter(Collider2D other)
    //{
    //    SceneManager.LoadScene("Title Scene");
    //    }
}
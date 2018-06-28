using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndControl : MonoBehaviour {
    public float endTime = 10;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        endTime -= Time.deltaTime;

        if (endTime < 0)
        {
            Application.Quit();
        }
    }
}

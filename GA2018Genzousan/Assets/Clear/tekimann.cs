using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tekimann : MonoBehaviour {
    public GameObject teki;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("v"))
        {
            GameObject obj = Instantiate(teki) as GameObject;
        }
	}
}

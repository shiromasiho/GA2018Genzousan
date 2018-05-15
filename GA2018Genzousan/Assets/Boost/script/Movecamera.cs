using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movecamera : MonoBehaviour {

    GameObject Player;

	// Use this for initialization
	void Start ()
    {
        this.Player = GameObject.Find("camera");
	}
	
	// Update is called once per frame
	void Update ()
    {
        this.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y,-10);	
	}
}

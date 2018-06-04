using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilmFire : MonoBehaviour
{

    public int filmflg;
    public GameObject playerfire;

    // Use this for initialization
    void Start()
    {
        filmflg = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z") && filmflg == 1)  //shoot
        {
            Instantiate(playerfire);
            filmflg = 0;
        }
        if (Input.GetKeyDown("x") && filmflg == 0)  //shoot
        {
            Destroy(gameObject);
            filmflg = 0;
        }
    }
}

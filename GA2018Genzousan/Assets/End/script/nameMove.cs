using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nameMove : MonoBehaviour
{
    private RectTransform Name;
    public float x, y, z;
    void Start()
    {
        Name = GameObject.Find("name").GetComponent<RectTransform>();
        // SEBGM = GameObject.Find("SE･BGM").GetComponent<RectTransform>();
        // Credit = GameObject.Find("credit").GetComponent<RectTransform>();

        // Name.localPosition = new Vector3(x, y, z);
    }
    void Update()
    {
        Name.localPosition = new Vector3(x, y += 1, z);
        // SEBGM.localPosition = new Vector3(x, y += 1, z);
        // Credit.localPosition = new Vector3(x, y += 1, z);

    }
}

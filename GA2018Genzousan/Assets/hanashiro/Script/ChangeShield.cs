using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 　// <- 追加


   

    
    public class ChangeShield : MonoBehaviour {
    public Sprite _on;
    public Sprite _off;
    private bool flg = true;

    public void changeImage()
    {
        var img = GetComponent<Image>();
        img.sprite = (flg) ? _on : _off;
        flg = !flg;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

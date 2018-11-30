using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SilverWerewolf : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        //マウスボタンクリック
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("SilverWerewolf_Scenes");
        }
    }
}

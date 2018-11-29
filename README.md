# Ikukoimonogatari
//Chapter.CSです//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDuwn(0)) {
            SceneManager.LoadScene();
        }
	}
}
/// <summary>
/// Chapter画面を読み込みます///
/// </summary>
/// SpiritStory_AkiraKamiya
public void ChangeScene()
{
    SceneManager.LoadScene();
}

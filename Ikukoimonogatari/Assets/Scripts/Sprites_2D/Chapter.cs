using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chapter : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Return))
        {


        }
        //マウスボタンクリックでキャラの物語画面に切り替わる 
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Chapter_Scenes");
        }
       
        }

    }



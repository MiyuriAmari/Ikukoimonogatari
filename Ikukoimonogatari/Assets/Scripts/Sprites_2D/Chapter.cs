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

        if( Input.GetMouseButtonDown( 0 ) )
        {
            SceneManager.LoadScene( 0 );
        }
    }

    /// <summary>
    /// Chapter画面を読み込みます///
    /// </summary>
    /// SpiritStory_AkiraKamiya
    public void ChangeScene()
    {
        SceneManager.LoadScene( 0 );
    }
}

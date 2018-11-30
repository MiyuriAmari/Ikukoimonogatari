using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// ホーム画面
/// </summary>
public class Home : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// Reality_Sceneを読み込みます
    /// </summary>
    public void ChangeScene( string sceneName )
    {
        Debug.Log(sceneName);
        SceneManager.LoadScene( sceneName );
    }
}
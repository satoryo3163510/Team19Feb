using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleDire : MonoBehaviour
{
    // spacekeyが押されたらステージセレクトシーンへ遷移
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //スペースキー
        if (Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("StageSelect");
    }
}

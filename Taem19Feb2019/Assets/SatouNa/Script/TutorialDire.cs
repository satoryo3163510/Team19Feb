using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialDire : MonoBehaviour
{
    //概要
    //右上の「ステージセレクトへ」ボタンが押されたら
    //ステージセレクトシーンへ遷移する
    void Start()
    {
    }

    void Update()
    {
    }
    public void OnClic()
    {
        SceneManager.LoadScene("StageSelect");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialDire : MonoBehaviour
{
    public Canvas canvasActive;
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
        canvasActive.enabled = false;
        SceneManager.LoadScene("StageSelect");
    }
}

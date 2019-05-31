using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionUI00 : MonoBehaviour
{
    //概要
    //playerの移動説明
    public Text misson01;   //解説テキスト
    private int count;      //次ページへ進むEnterのカウント
    // Start is called before the first frame update
    void Start()
    {
        misson01.text = ("基本動作テストを開始します");
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //テキスト書き換え(Enterキー）
        if (Input.GetKeyDown(KeyCode.Return) && count == 0)
        {
            misson01.text = ("WキーSキーで前後に移動し、 AキーDキーで左右に旋回 します。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 1)
        {
            misson01.text = ("↑↓←→（アローキー）でも 移動できます。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 2)
        {
            misson01.text = ("マウスによって視界を 動かします。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 3)
        {
            misson01.text = ("以上で基本動作テストを 終了します。 次の項目へ進んでください");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Backspace))
        {
            gameObject.GetComponent<MissionUI01>().enabled = true;
            gameObject.GetComponent<MissionUI00>().enabled = false;
        }
    }
}

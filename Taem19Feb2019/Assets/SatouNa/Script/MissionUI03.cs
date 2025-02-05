﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionUI03 : MonoBehaviour
{
    //playerのシールド機能の説明
    public Text misson01;
    public GameObject m_Cube_s;     //攻撃してくるcube_s
    [SerializeField]
    private Vector3[] m_CubePos;
    private int count;
    private GameObject m_Cubes;

    // Start is called before the first frame update
    void Start()
    {
        misson01.text = ("シールド機能のテストを 開始します。");
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //テキスト書き換え(Enterキー）
        if (Input.GetKeyDown(KeyCode.Return) && count == 0)
        {
            misson01.text = ("スコープモードではない状態で 左クリックでシールドを 展開します。");
            count++;
            
           m_Cubes = Instantiate(m_Cube_s, m_CubePos[0], Quaternion.identity);
          
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 1)
        {
            misson01.text = ("シールド展開中に 再度左クリックで シールドを解除します。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 2)
        {
            misson01.text = ("シールド展開中は 徐々に右下のシールドゲージを 消費します。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 3)
        {
            misson01.text = ("通常、敵の攻撃を受けると 右下のＨＰゲージが 減少します。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 4)
        {
            misson01.text = ("しかしシールド展開中に 攻撃を受けると シールドがダメージを 肩代わりします。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 5)
        {
            misson01.text = ("シールドゲージが0になると シールドが解除されます。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 6)
        {
            misson01.text = ("以上でシールド機能のテストを 終了します。 次の項目へ進んでください");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Destroy(m_Cubes);

            gameObject.GetComponent<MissionUI04>().enabled = true;
            gameObject.GetComponent<MissionUI03>().enabled = false;
        }
    }
}

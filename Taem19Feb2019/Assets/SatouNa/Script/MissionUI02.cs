using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionUI02 : MonoBehaviour
{
    //playerのミサイル（ボム）の説明
    public Text misson01;
    public GameObject m_Cube;
    [SerializeField]
    private Vector3[] m_CubePos;
    private int count;
    private GameObject[] m_Cubes = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {
        misson01.text = ("ミサイルの動作確認をします");
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //テキスト書き換え(Enterキー）
        if (Input.GetKeyDown(KeyCode.Return) && count == 0)
        {
            misson01.text = ("自機の見えている状態で マウスを操作して 対象を画面の中心に 捉えてください。");
            count++;
            for (int i = 0; i < 3; i++)
            {
                m_Cubes[i] = Instantiate(m_Cube, m_CubePos[i], Quaternion.identity);
            }

        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 1)
        {
            misson01.text = ("スペースキーでミサイルを 発射します。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 2)
        {
            misson01.text = ("ミサイルは直進し 敵を発見すると 自動で追尾します。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 3)
        {
            misson01.text = ("ミサイルの数には限りがあり 左下で残りの弾数を 確認できます。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 4)
        {
            misson01.text = ("ミサイルは補給できないので 使いどころに注意 してください。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 5)
        {
            misson01.text = ("以上でミサイルの動作テストを 終了します。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 6
            ||Input.GetKeyDown(KeyCode.Backspace))
        {
            foreach (GameObject cubes in m_Cubes)
            {
                Destroy(cubes);
            }
            gameObject.GetComponent<MissionUI03>().enabled = true;
            gameObject.GetComponent<MissionUI02>().enabled = false;
        }
    }
}

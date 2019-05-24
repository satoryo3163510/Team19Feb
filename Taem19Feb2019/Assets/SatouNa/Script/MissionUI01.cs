using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionUI01 : MonoBehaviour
{
    public Text misson01;
    public GameObject m_Cube;
    [SerializeField]
    private Vector3[] m_CubePos;
    private int count;
    private GameObject[] m_Cubes = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {
        misson01.text=("機体のテストを開始します Enter-次へ");
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //テキスト書き換え(Enterキー）
        if (Input.GetKeyDown(KeyCode.Return) && count == 0)
        {
            misson01.text = ("まずは正面のキューブに レーザーで攻撃してみましょう Enter-次へ");
            count++;
            for (int i = 0; i < 3; i++)
            {
                m_Cubes[i] = Instantiate(m_Cube, m_CubePos[i], Quaternion.identity);
            }

        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 1)
        {
            misson01.text = ("右クリックでスコープモードに移行します Enter-次へ");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 2)
        {
            misson01.text = ("スコープモードは画面中央に 狙いをつける矢印が表示されます Enter-次へ");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 3)
        {
            misson01.text = ("この状態で左クリックするとレーザー攻撃を行います Enter-次へ");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 4)
        {
            misson01.text = ("マウスのホイールを動かすと 拡大倍率が変化します Enter-次へ");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 5)
        {
            misson01.text = ("以上でレーザー攻撃のテストを終了します Enter-次へ");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 6)
        {
            foreach(GameObject cubes in m_Cubes)
            {
                Destroy(cubes);
            }
            
            gameObject.GetComponent<MissionUI02>().enabled = true;
            gameObject.GetComponent<MissionUI01>().enabled = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MissionUI04 : MonoBehaviour
{
    //概要
    //ゲームの目的、勝利条件の提示
    //終了時にステージセレクトシーンに遷移

    public Text misson01;           
    public GameObject tower;        //タワー（敵拠点）
    public GameObject shieldEnemy;  //シールド艦（タワーの護衛艦）
    [SerializeField]
    private Vector3[] m_CubePos;
    private int count;
    private GameObject[] enemys = new GameObject[2];

    // Start is called before the first frame update
    void Start()
    {
        misson01.text = ("それでは作戦を説明します。");
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //テキスト書き換え(Enterキー）
        if (Input.GetKeyDown(KeyCode.Return) && count == 0)
        {
            misson01.text = ("今回の目標は敵拠点のタワー の破壊です。");
            count++;
            
            enemys[0] = Instantiate(tower, m_CubePos[0], Quaternion.identity);
            
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 1)
        {
            misson01.text = ("動力源であるタワーが破壊され れば敵の戦闘続行能力は 失われるでしょう。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 2)
        {
            misson01.text = ("タワーは敵のシールドによって 守られています。 先にシールド艦二隻を 無力化してください。");
            count++;
            enemys[1] = Instantiate(shieldEnemy, m_CubePos[1], Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 3)
        {
            misson01.text = ("シールド艦は攻撃してきません が護衛艦及びタワー本体からの 攻撃に気を付けてください。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 4)
        {
            misson01.text = ("特にタワー本体からの攻撃は 非常に危険です。 緊急時にはシールドで 凌いでください。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 5)
        {
            misson01.text = ("以上で説明を終了します。 Enter-出撃エリア選択画面 に移行します。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 6
            || Input.GetKeyDown(KeyCode.Backspace))
        {
            foreach (GameObject enemy in enemys)
            {
                Destroy(enemy);
            }

            gameObject.GetComponent<MissionUI00>().enabled = true;
            gameObject.GetComponent<MissionUI04>().enabled = false;

            SceneManager.LoadScene("StageSelect");
        }
    }
}

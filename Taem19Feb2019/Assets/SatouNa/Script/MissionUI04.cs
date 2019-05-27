using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MissionUI04 : MonoBehaviour
{
    // Start is called before the first frame update
    public Text misson01;
    public GameObject tower;
    public GameObject shieldEnemy;
    [SerializeField]
    private Vector3[] m_CubePos;
    private int count;
    private GameObject[] enemys = new GameObject[2];

    // Start is called before the first frame update
    void Start()
    {
        misson01.text = ("それでは作戦目標を説明します。");
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //テキスト書き換え(Enterキー）
        if (Input.GetKeyDown(KeyCode.Return) && count == 0)
        {
            misson01.text = ("今回の目標は敵拠点のタワーの破壊です。");
            count++;
            
            enemys[0] = Instantiate(tower, m_CubePos[0], Quaternion.identity);
            
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 1)
        {
            misson01.text = ("動力源であるタワーが破壊されれば 敵の戦闘続行能力は失われるでしょう。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 2)
        {
            misson01.text = ("タワーは敵のシールドによって守られています。 先に（仮称）シールド艦二隻を無力化してください。");
            count++;
            enemys[1] = Instantiate(shieldEnemy, m_CubePos[1], Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 3)
        {
            misson01.text = ("シールド艦は攻撃してきませんが、護衛艦及びタワー本体からの攻撃に気を付けてください。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 4)
        {
            misson01.text = ("特にタワー本体からの攻撃は非常に危険です。 緊急時にはシールドで凌いでください。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 5)
        {
            misson01.text = ("以上で説明を終了します。 Enter-出撃エリア選択画面に移行します。");
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

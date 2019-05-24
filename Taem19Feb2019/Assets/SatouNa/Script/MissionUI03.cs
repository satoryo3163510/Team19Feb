using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionUI03 : MonoBehaviour
{
    public Text misson01;
    public GameObject m_Cube_s;
    [SerializeField]
    private Vector3[] m_CubePos;
    private int count;
    private GameObject m_Cubes;

    // Start is called before the first frame update
    void Start()
    {
        misson01.text = ("シールド機能のテストを開始します。");
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //テキスト書き換え(Enterキー）
        if (Input.GetKeyDown(KeyCode.Return) && count == 0)
        {
            misson01.text = ("機体が見える状態（スコープモードではない状態）で 右クリックでシールドを展開します。");
            count++;
            
           m_Cubes = Instantiate(m_Cube_s, m_CubePos[0], Quaternion.identity);
          
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 1)
        {
            misson01.text = ("シールド展開中に再度右クリックで シールドを解除します。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 2)
        {
            misson01.text = ("シールド展開中は徐々に右下のシールドゲージを消費します。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 3)
        {
            misson01.text = ("通常、敵の攻撃を受けると右下のＨＰゲージが減少します。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 4)
        {
            misson01.text = ("しかしシールド展開中に攻撃を受けると シールドがダメージを肩代わりします。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 5)
        {
            misson01.text = ("シールドゲージが0になると シールドが解除されます。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 6)
        {
            misson01.text = ("以上でシールド機能のテストを終了します。");
            count++;
        }
        else if (Input.GetKeyDown(KeyCode.Return) && count == 7||
            Input.GetKeyDown(KeyCode.Backspace))
        {
            Destroy(m_Cubes);

            gameObject.GetComponent<MissionUI04>().enabled = true;
            gameObject.GetComponent<MissionUI03>().enabled = false;
        }
    }
}

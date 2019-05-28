using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionUIResult : MonoBehaviour
{
    //ゲーム結果表示テキスト
    public Text resultText;     //結果
    private bool DeadOrAlive;

    // Start is called before the first frame update
    void Start()
    {
        DeadOrAlive = PlayerHp.ResultReturn();
        if (DeadOrAlive)
        {
            resultText.text = "MISSION COMPLETE";
        }
        else
        {
            resultText.text = "MISSION FAILED";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

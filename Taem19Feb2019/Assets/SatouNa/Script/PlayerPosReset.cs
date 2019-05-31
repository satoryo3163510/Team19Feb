using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosReset : MonoBehaviour
{
    //概要
    //pキー・Backspaceが押されたらplayerを初期位置に戻す

    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos =transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)
            ||Input.GetKeyDown(KeyCode.Backspace))
            transform.position = startPos;
    }
}

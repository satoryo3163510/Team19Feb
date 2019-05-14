﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasyDire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //スペースキー
        if (Input.GetKeyDown(KeyCode.N))
            SceneManager.LoadScene("Result");
    }

    public void NextResult()
    {
        SceneManager.LoadScene("Result");
    }
}

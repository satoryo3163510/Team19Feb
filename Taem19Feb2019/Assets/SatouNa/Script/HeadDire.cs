﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadDire : MonoBehaviour
{
    private PlayerHp php;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //if (php.Returndeath() == true)
        //{
        //    SceneManager.LoadScene("Defeat");
        //}
        if (Input.GetKeyDown(KeyCode.Space)) SceneManager.LoadScene("Title");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultDire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
    }
    
    // Update is called once per frame
    void Update()
    {
        //スペースキー
        if (Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("Title");
    }
}

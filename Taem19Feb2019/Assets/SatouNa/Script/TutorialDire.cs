using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialDire : MonoBehaviour
{
    [SerializeField]
    GameObject cship;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //スペースキー
        if (Input.GetKeyDown(KeyCode.P))
            SceneManager.LoadScene("Result");
        if (cship.GetComponent<EnemyHp>().Return() < 0)
        {
            SceneManager.LoadScene("Result");
        }
    }
}

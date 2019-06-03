using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasyDire : MonoBehaviour
{
    private PlayerHp php;
    [SerializeField]
    private GameObject cship;
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("Player");
        php = player.GetComponent<PlayerHp>();
        //cship.GetComponent<EnemyHp>();
    }


    // Update is called once per frame
    void Update()
    {
        //スペースキー
        if (Input.GetKeyDown(KeyCode.N)) SceneManager.LoadScene("Result");
        

        if (cship.GetComponent<EnemyHp>().Return() < 0)
        {
            NextResult();
        }
        if (php.Returndeath() == true)
        {
            NextDefeat();
        }
    }

    public void NextResult()
    {
        SceneManager.LoadScene("Result");
    }
    public void NextDefeat()
    {
        SceneManager.LoadScene("Defeat");
    }
   
}

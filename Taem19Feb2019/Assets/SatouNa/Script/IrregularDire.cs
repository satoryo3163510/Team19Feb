using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IrregularDire : MonoBehaviour
{
    private PlayerHp php;
    private EnemyHp ehp;
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("Player");
        php = player.GetComponent<PlayerHp>();
        ehp = new EnemyHp();
    }

    // Update is called once per frame
    void Update()
    {
        if (ehp.Return() < 0)
        {
            SceneManager.LoadScene("Result");
        }
        if (php.Returndeath() == true)
        {
            SceneManager.LoadScene("Defeat");
        }
    }
}

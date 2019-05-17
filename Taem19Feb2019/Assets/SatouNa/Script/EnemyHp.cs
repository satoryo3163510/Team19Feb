using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    //エネミーのHp,消滅関係
    [SerializeField]
    private float enemyHp;
    [SerializeField]
    private float maxEnemyHp = 100f;

    // hpの初期化
    void Start()
    {
        enemyHp = maxEnemyHp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnemyDamage(float damage)
    {
        enemyHp -= damage;
        if (enemyHp <= 0)
            Destroy(gameObject,2f);
    }
}

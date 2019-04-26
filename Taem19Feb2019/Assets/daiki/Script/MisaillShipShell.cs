using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisaillShipShell : MonoBehaviour
{
    public GameObject EnemyBullet;
   
    float Z_Speed = 0;
    float intervalTime;

    // 敵が攻撃する間隔
    float enemyAttackInterval;
    // 経過時間 
    float enemyAttackTimer;

    void Start()
    {
        // enemyAttackIntervalを初期化、5~10の数値が入る
        enemyAttackInterval = Random.Range(1.0f, 5.0f);
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -1 * Z_Speed);
        //以下、攻撃用コード
        Quaternion quat = Quaternion.Euler(0, 180, 0);
        intervalTime += Time.deltaTime;
        if (intervalTime >= enemyAttackInterval)
        {
            intervalTime = 0.0f;
            enemyAttackTimer = 0; // タイマーを戻す
            enemyAttackInterval = Random.Range(5.0f, 10.0f);
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat);
        }
        enemyAttackTimer += Time.deltaTime;


    }

   

    }

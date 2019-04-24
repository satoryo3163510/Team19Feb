﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misaill : MonoBehaviour
{
    //Rigidbodyを入れる
    Rigidbody rigid;
    //速度
    Vector3 velocity;
    //発射するときの初期位置
    public Vector3 position;

    //加速度
    public Vector3 acceleration;
    //ターゲットをセット
    public Transform target;

    //着弾時間
    float period = 2f;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        rigid = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        acceleration = Vector3.zero;
    //ターゲットと自分自身の差
        var diff = target.position - transform.position;
        //加速度を求めてるらしい
        acceleration += (diff - velocity * period) * 2f / (period * period);
        //加速度が一定以上だと追尾を弱くする
        if (acceleration.magnitude > 100f)
        {
            acceleration = acceleration.normalized * 100f;
        }

        //着弾時間を徐々に減らす
        period -= Time.deltaTime;

        //速度の計算
        velocity += acceleration * Time.deltaTime;
    }

    void FixedUpdate()
    {
        //移動処理
        rigid.MovePosition(transform.position + velocity * Time.deltaTime);

    }

    void OnCollisionEnter()
    {
        Destroy(this.gameObject);
    }
}

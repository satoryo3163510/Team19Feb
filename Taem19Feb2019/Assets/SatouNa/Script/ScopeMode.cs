﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeMode : MonoBehaviour
{
    //概要
    //射撃に関するスクリプト
    public GameObject bullet;               //発射するオブジェクト
    public Transform[] fpsCamera_s;         //発射する場所
    private Camera fpsCamera;               //一人称カメラ
    private int zoom1 = 10;                 //拡大倍率（近）
    private int zoom2 = 20;                 //拡大倍率（遠）
    private bool zoomFlag;                  //切り替えフラグ
    private Vector3 center;                 //画面中央座標
    private EnemyHp EH;
    private bool shootOk;
    public float countTime;
    [SerializeField]
    private float laserDamage;
    private GameObject bullets;


    // Start is called before the first frame update
    void Start()
    {
        fpsCamera = GetComponent<Camera>();
        fpsCamera.fieldOfView = zoom2;
        center = new Vector3(Screen.width / 2, Screen.height / 2);
        shootOk = true;
    }

    // Update is called once per frame
    void Update()
    {
        //左クリックで射撃
        if (Input.GetMouseButtonDown(0)&&shootOk==true)
        {
            Shoot();
            shootOk = false;
            countTime = 0;
        }

        if (!shootOk)
        {
            countTime += Time.deltaTime;
            if (countTime >= 2)
                shootOk = true;
        }

        //拡大倍率の変更
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0)
        {
            if (scroll > 0) zoomFlag = true;
            else zoomFlag = false;
        }

        //拡大縮小の遷移をスムーズに見せる
        if (zoomFlag == true&&fpsCamera.fieldOfView>zoom1)
        {
            fpsCamera.fieldOfView--;
        }
        else if (zoomFlag == false && fpsCamera.fieldOfView < zoom2)
        {
            fpsCamera.fieldOfView++;
        }
    }

    //射撃
    void Shoot()
    {
        //エフェクト
        for(int i = 0;i < 4; i++)
        {
            bullets = Instantiate(bullet) as GameObject;
            bullets.transform.position = fpsCamera_s[i].transform.position;
            bullets.transform.rotation = fpsCamera.transform.rotation;
            Destroy(bullets, 1f);
        }
       
  
        //レーザー射撃
        Ray ray = fpsCamera.ScreenPointToRay(center);
        RaycastHit hit;

        //rayがhitした場合
        if (Physics.Raycast(ray,out hit, 80f))
        {
           if(hit.collider.gameObject.tag == "Enemy")
            {
                EH = hit.collider.GetComponent<EnemyHp>();
                EH.EnemyDamage(laserDamage);
                Destroy(bullets,0.4f);
            }
        }
    }
}

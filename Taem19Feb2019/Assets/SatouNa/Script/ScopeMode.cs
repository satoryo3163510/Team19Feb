using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeMode : MonoBehaviour
{
    //射撃に関するスクリプト
    public GameObject bullet;               //発射するオブジェクト
    public Transform muzzle;                //発射する場所
    [SerializeField]
    private  float bulletSpeed = 1000f;     //弾速
    private Camera fpsCamera;               //一人称カメラ
    private int zoom1 = 10;                 //拡大倍率（近）
    private int zoom2 = 20;                 //拡大倍率（遠）
    private bool zoomFlag;                  //切り替えフラグ
    


    // Start is called before the first frame update
    void Start()
    {
        fpsCamera = GetComponent<Camera>();
        fpsCamera.fieldOfView = zoom2;
    }

    // Update is called once per frame
    void Update()
    {
        //左クリックで射撃
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

        //拡大倍率の変更
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0)
        {
            if (scroll > 0) zoomFlag = true;
            else zoomFlag = false;
        }

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
        GameObject bullets = Instantiate(bullet) as GameObject;
        Vector3 force;
        force = this.gameObject.transform.forward * bulletSpeed;

        bullets.GetComponent<Rigidbody>().AddForce(force);

        bullets.transform.position = muzzle.position;
    }
}

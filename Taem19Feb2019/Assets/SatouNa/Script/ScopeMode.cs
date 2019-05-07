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
    private Vector3 center;                 //画面中央座標
    


    // Start is called before the first frame update
    void Start()
    {
        fpsCamera = GetComponent<Camera>();
        fpsCamera.fieldOfView = zoom2;
        center = new Vector3(Screen.width / 2, Screen.height / 2);
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
        //実弾処理、エフェクトに転用できるのでコメントアウト
        //GameObject bullets = Instantiate(bullet) as GameObject;
        //Vector3 force;
        //force = this.gameObject.transform.forward * bulletSpeed;
        //force = fpsCamera.transform.forward * bulletSpeed;

        //bullets.GetComponent<Rigidbody>().AddForce(force);

        //bullets.transform.position = muzzle.position;

        //レーザー射撃
        Ray ray = fpsCamera.ScreenPointToRay(center);
        RaycastHit hit;

        //rayの可視化用デバッグ
        Debug.DrawRay(ray.origin, ray.direction*10, Color.green, 5, false);

        //rayがhitした場合
        if (Physics.Raycast(ray,out hit, 100))
        {
            //destroyの時間差で演出を入れる
            Destroy(hit.collider.gameObject);
           
        }
    }
}

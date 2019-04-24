using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowCamera : MonoBehaviour
{
    private GameObject mainCamera;//メインカメラ格納用

    private GameObject playerObject;//回転の中心となるプレイヤー

    private float rotateSpeed = 0.5f;//回転の速さ

    // Start is called before the first frame update
    void Start()
    {
        //メインカメラと戦艦を取得
        mainCamera = Camera.main.gameObject;

        playerObject = GameObject.Find("PlayerSenkan");

    }

    // Update is called once per frame
    //単位時間ごとに実装させる関数
    void Update()
    {
        //rotateCameraの呼び出し
        rotateCamera();
    }

    //カメラを回転させる関数
    private void rotateCamera()
    {
        //Vector3でX,Y方向の回転度合いの定義
        Vector3 angl = new Vector3(Input.GetAxis("Mouse X") * -rotateSpeed, Input.GetAxis("Mouse Y") * -rotateSpeed, 0);
        //transform.RtateAround()をしようしてメインカメラを回転させる
        mainCamera.transform.RotateAround(playerObject.transform.position, Vector3.down, angl.x);

        mainCamera.transform.RotateAround(playerObject.transform.position, transform.right, angl.y);
    }
}

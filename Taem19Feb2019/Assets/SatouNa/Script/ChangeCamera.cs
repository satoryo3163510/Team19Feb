using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject mainCamera;

    [SerializeField]
    private GameObject subCamera;

    private GameObject playerObject;//回転の中心となるプレイヤー
    private float rotateSpeed = 0.5f;//回転の速さ
    public Image sight;


    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.Find("PlayerSenkan");
        gameObject.GetComponent<ScopeMode>().enabled = false;
        sight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //rotateCameraの呼び出し
        RotateCamera();

        //右クリックが押されたらカメラのアクティブを切り替える
        if (Input.GetMouseButtonDown(1))
        {
            mainCamera.SetActive(!mainCamera.activeSelf);
            subCamera.SetActive(!subCamera.activeSelf);
        }
    }

    private void RotateCamera()
    {
        
        //transform.RtateAround()をしようしてメインカメラを回転させる
        if (mainCamera.activeSelf)
        {
            //Vector3でX,Y方向の回転度合いの定義
            Vector3 angl = new Vector3(Input.GetAxis("Mouse X") * -rotateSpeed, Input.GetAxis("Mouse Y") * -rotateSpeed, 0);
            mainCamera.transform.RotateAround(playerObject.transform.position, Vector3.down, angl.x);
            mainCamera.transform.RotateAround(playerObject.transform.position, transform.right, angl.y);
            gameObject.GetComponent<ScopeMode>().enabled = false;
            sight.enabled = false;
        }
        else if (subCamera.activeSelf)
        {
            Vector3 angl = new Vector3(Input.GetAxis("Mouse X") * -rotateSpeed*0.4f, Input.GetAxis("Mouse Y") * -rotateSpeed*0.4f, 0);
            subCamera.transform.RotateAround(playerObject.transform.position, Vector3.down, angl.x);
            subCamera.transform.RotateAround(playerObject.transform.position, transform.right, angl.y);
            gameObject.GetComponent<ScopeMode>().enabled = true;
            sight.enabled = true;
        }

    }
}

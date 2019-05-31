using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //プレイヤーの移動、操作スクリプト
    private Rigidbody rb;

    //船の速度
    private float shipSpeed;

    //船の旋回速度
    [SerializeField]
    private float turnspeed = 6f;

    //船の後退速度上限
    [SerializeField]
    private float backMaxSpeed = 0.8f;

    //船の前進速度上限
    [SerializeField]
    private float maxSpeed = 1.2f;

    //船の出力
    [SerializeField]
    private float shipPower = 2f;

    ChangeCamera changeCamera;
    int aaa;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GameObject camera = GameObject.Find("Main Camera");
        changeCamera = camera.GetComponentInChildren<ChangeCamera>();
        changeCamera = new ChangeCamera();
    }

    // Update is called once per frame
    void Update()
    {
        //船の現在速度取得
        shipSpeed = Mathf.Abs(rb.velocity.z);
        aaa = changeCamera.ReturnFlag();
    }

    //物理演算で呼ばれる処理
    void FixedUpdate()
    {
        float move_x = Input.GetAxis("Horizontal");
        float move_z = Input.GetAxis("Vertical");

        switch (aaa)
        {
            case 0:
                //前後移動(速度制限付き)
                if (move_z > 0)
                {
                    if (maxSpeed > shipSpeed)
                        rb.AddForce(transform.right * shipPower);
                }
                else if (move_z < 0)
                {
                    if (backMaxSpeed > shipSpeed)
                        rb.AddForce(transform.right * -shipPower);
                }
                break;
            case 1:
                Debug.Log(aaa);
                //前後移動(速度制限付き)
                if (move_z > 0)
                {
                    if (maxSpeed > shipSpeed)
                        rb.AddForce(transform.right * shipPower*0);
                }
                else if (move_z < 0)
                {
                    if (backMaxSpeed > shipSpeed)
                        rb.AddForce(transform.right * -shipPower*0);
                }
                break;

        }

        //旋回
        float turn = move_x * turnspeed * Time.deltaTime;
        Quaternion turnrotation = Quaternion.Euler(0, turn, 0);
        rb.MoveRotation(rb.rotation * turnrotation);
    }
}

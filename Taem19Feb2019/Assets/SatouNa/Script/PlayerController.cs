using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    private float shipSpeed;
    public float turnspeed; //途中

    [SerializeField]
    private float backMaxSpeed = 0.8f;

    [SerializeField]
    private float maxSpeed = 10f;

    [SerializeField]
    private float shipPower = 2f;

    [SerializeField]
    private float rotation = 2f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        shipSpeed =Mathf.Abs(rb.velocity.z);
    }

    //物理演算で呼ばれる処理
    void FixedUpdate()
    {
        float move_x = Input.GetAxis("Horizontal");
        float move_z = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.W))
        {
            if(maxSpeed>shipSpeed)
            rb.AddForce(0, 0, shipPower);
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (backMaxSpeed > shipSpeed)
                rb.AddForce(0, 0,-shipPower );
        }

        //旋回途中
        float turn = move_x * turnspeed * Time.deltaTime;
        Quaternion trunrotation = Quaternion.Euler(0, turn, 0);
        rb.MoveRotation(rb.rotation * trunrotation);


    }
}

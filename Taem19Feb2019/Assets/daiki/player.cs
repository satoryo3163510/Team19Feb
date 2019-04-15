using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController),typeof(AudioSource))]

public class player : MonoBehaviour
{
    [SerializeField]
    private string fire1String;

    [SerializeField]
    public int pnString;

    public float speed = 5f;

    public float countTime;
    float count = 0f;

    private Vector3 Player_pos;
    private float x;
    private float z;
    private Rigidbody rigid;
    

    void Start()
    {
        GetComponent<Rigidbody>().rotation = Quaternion.identity;

        Player_pos = GetComponent<Transform>().position;

        rigid = GetComponent<Rigidbody>();
        //transform.position -= new Vector3(0, 0, 0);
        //gameObject.GetComponent<player>().enabled = true;
        //count = 0;
        //countTime = 4;
    }

    // Update is called once per frame
     void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Velotical");

        //（仮）
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigid.AddForce(x * speed, 0, z * speed);
        
        //向いている方向
        Vector3 diff = transform.position - Player_pos;
        Rigidbody rd = this.transform.GetComponent<Rigidbody>();
        rd.velocity = new Vector3(x, 0, z);
        Vector3 veloctiy = rd.rotation * new Vector3(0, 0, speed);

        countTime -= Time.deltaTime;

        gameObject.transform.position += veloctiy * Time.deltaTime;
        if (diff.magnitude > 0.0f)
        {
            transform.rotation = Quaternion.LookRotation(diff);
        }
        Player_pos = transform.position;

     
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    //ミサイル発射プログラム
    //敵に当たるまで止まることはない

    private Rigidbody rb;
    [SerializeField]
    private float speed;
    private Vector3 force;

    
    // Use this for initialization
    void Start()
    {
        force = transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        rb.AddForce(force);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            //範囲内の敵に必中する。
        }
    }
}

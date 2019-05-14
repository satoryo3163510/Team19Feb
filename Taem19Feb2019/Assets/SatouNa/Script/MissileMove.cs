using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMove : MonoBehaviour
{
    //ミサイルの挙動
    //考え中
    [SerializeField]
    private float secondSpeed;
    private Rigidbody rb;
    private Vector3 force;


    // Start is called before the first frame update
   void Start()
    {
        rb = GetComponent<Rigidbody>();
        force = transform.forward * secondSpeed;
        rb.AddForce(force,ForceMode.Impulse);
    }

    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Vector3 aim = other.transform.position - transform.position;
            Quaternion look = Quaternion.LookRotation(aim, Vector3.up);
            transform.localRotation = look;
            rb.AddForce(transform.forward);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("hit!");
        }
    }

}

    

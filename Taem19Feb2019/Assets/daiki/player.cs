using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 0.5f;

    private Vector3 Player_pos;
    private float x;
    private float y;
    

    void Start()
    {
        Player_pos = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Rigidbody rigidbody = GetComponent<Rigidbody>();

        rigidbody.AddForce(x * speed, 0, z * speed);

        Vector3 diff = transform.position - Player_pos;
        if (diff.magnitude > 0.01f)
        {
            transform.rotation = Quaternion.LookRotation(diff);
        }

        Player_pos = transform.position;
    }

        
    
}

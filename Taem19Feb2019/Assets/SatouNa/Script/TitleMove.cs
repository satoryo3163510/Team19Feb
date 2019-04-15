using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleMove : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 force = new Vector3(0f, 0f, 1.0f);
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(force);
    }
}

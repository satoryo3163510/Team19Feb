using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeMode : MonoBehaviour
{
    public GameObject bullet;
    public Transform muzzle;
    public float speed = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullets = Instantiate(bullet) as GameObject;
            Vector3 force;
            force = this.gameObject.transform.forward * speed;

            bullets.GetComponent<Rigidbody>().AddForce(force);

            bullets.transform.position = muzzle.position;
        }
    }
}

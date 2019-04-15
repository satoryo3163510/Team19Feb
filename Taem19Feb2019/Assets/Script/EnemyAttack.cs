using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public  GameObject bullet;
    private float timer;
    public Transform muzzle;
    private float bSpeed = 100;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
        if (timer >= 0.1)
        {
            GameObject bullets = Instantiate(bullet) as GameObject;
            Vector3 force = gameObject.transform.right * bSpeed;
            bullets.GetComponent<Rigidbody>().AddForce(force);
            bullets.transform.position = muzzle.position;
            Destroy(bullets, 5);
            timer = 0;
        }
    }
}

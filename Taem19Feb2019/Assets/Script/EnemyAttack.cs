using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject bullet;
    private float timer;
    public float kankaku = 3;
    public Transform[] muzzles;
    private float bSpeed = 100;
    private bool attackStart;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (attackStart== true)
        {
            if (timer >= kankaku)
            {
                for (int i = 0; i < muzzles.Length; i++)
                {
                    GameObject bullets = Instantiate(bullet) as GameObject;
                    Vector3 force = gameObject.transform.right * bSpeed;
                    bullets.GetComponent<Rigidbody>().AddForce(force);
                    bullets.transform.position = muzzles[i].position;
                    Destroy(bullets, 5);
                }
                timer = 0;
            }
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            attackStart = true;
        }
    }
    void OnTriggerStay(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            attackStart = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            attackStart = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_Cannon : MonoBehaviour
{
    public GameObject bullet;
    public Transform muzzle;
    private float timer;
    private float speed = 900f;
    public GameObject EF_laser2;
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        var aim = player.position - transform.position;
        var look = Quaternion.LookRotation(aim);
        transform.localRotation = look;
        timer += Time.deltaTime;
        if (timer>=3.0f)
        {
           
            GameObject bullets = Instantiate(bullet, muzzle.position,look);
            bullets.GetComponent<Rigidbody>().AddForce(transform.forward*speed);
            GameObject ef_laser = Instantiate(EF_laser2, muzzle.position,look);
            Destroy(ef_laser, 3f);
            Destroy(bullets, 3f);
            timer = 0;
        }
    }
}
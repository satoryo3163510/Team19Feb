using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_EnemyAttack : MonoBehaviour
{
    public GameObject bullet,phantombullet;
    private float timer;
    public float kankaku = 3;
    public float lifeTime;
    public Transform[] muzzles;
    private float bSpeed = 180;
    private bool attackStart;
    private string player = "Player";
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (attackStart == true)
        {
            if (timer >= kankaku)
            {
                for (int i = 0; i < muzzles.Length; i++)
                {
                    GameObject bullets1 = Instantiate(phantombullet) as GameObject;
                    Vector3 force = gameObject.transform.right * bSpeed;
                    bullets1.GetComponent<Rigidbody>().AddForce(force);
                    bullets1.transform.position = muzzles[i].position;
                    Destroy(bullets1, lifeTime-0.8f);
                }
                for (int i = 0; i < muzzles.Length; i++)
                {
                    GameObject bullets = Instantiate(bullet) as GameObject;
                    //Vector3 force = gameObject.transform.right * bSpeed;
                    //bullets.GetComponent<Rigidbody>().AddForce(force);
                    bullets.transform.position = muzzles[i].position;
                    bullets.transform.rotation = gameObject.transform.rotation;
                    bullets.transform.Rotate(new Vector3(0, 90, 0));
                    Destroy(bullets, lifeTime);
                }
                timer = 0;
            }
           
        }
        //if(bulletaaaa.retrnaaaa()==true)
        //{
        //    Debug.Log(bulletaaaa.retrnaaaa());
        //    Destroy(bullet);
        //}
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag(player))
        {
            attackStart = true;
        }
    }
    void OnTriggerStay(Collider col)
    {
        if (col.CompareTag(player))
        {
            attackStart = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == player)
        {
            attackStart = false;
        }
    }
}

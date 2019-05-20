using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Transform player;
    bool aaaa;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        aaaa = false;
    }

    // Update is called once per frame
    void Update()
    {
        var aim = player.position - transform.position;
        var look = Quaternion.LookRotation(aim);
        transform.localRotation = look;
    }
    void OnTriggerEnter(Collider col)
    {
        //Playerと当たったら消す
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            aaaa = true;
        }
    }
    public bool retrnaaaa()
    {
        return aaaa;
    }
}

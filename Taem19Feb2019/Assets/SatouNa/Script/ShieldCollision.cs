using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCollision : MonoBehaviour
{
    private PlayerShield PS;
    private GameObject player;
    public GameObject EF_shieldHit;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        PS = player.GetComponent<PlayerShield>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    //シールドに敵が接触した
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" || gameObject.tag == "EnemyBullet")
        {
            var hit = Instantiate(EF_shieldHit, transform.position, Quaternion.identity);
            Destroy(hit, 1f);
            PS.ShieldDamage(10.0f);
        }
    }
}

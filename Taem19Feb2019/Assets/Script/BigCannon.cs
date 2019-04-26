using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCannon : MonoBehaviour
{
    private Transform player;
    private Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerSenkan").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Playerを見る
        var aim = player.position - transform.position;
        var look = Quaternion.LookRotation(aim,Vector3.up);
        transform.localRotation = look;
        //transform.LookAt(player);
    }
}

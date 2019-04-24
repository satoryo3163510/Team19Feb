using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
<<<<<<< HEAD
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
=======
    private Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
              
>>>>>>> No01s
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        //Vector3 dir = player.position - transform.position;
        //transform.forward = dir;
        //float step = speed * Time.deltaTime;
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, player.rotation, step);
        //transform.rotation = Quaternion.LookRotation(player.position);
        //transform.LookAt(player.position);
        //Vector3 targetDir = player.position - transform.position;
        //targetDir.y = transform.position.y; //targetと高さが異なると体ごと上下を向いてしまうので制御
        //float step = speed * Time.deltaTime;
        //Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 10.0F);
        //transform.rotation = Quaternion.LookRotation(newDir);

        var aim = player.position - transform.position;
        var look = Quaternion.LookRotation(aim);
        transform.localRotation = look;
=======
        gameObject.transform.Translate(0.1f, 0, 0);
>>>>>>> No01s
    }
}

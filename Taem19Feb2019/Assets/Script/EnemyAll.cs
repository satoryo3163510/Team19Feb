using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAll : MonoBehaviour
{
    //エネミー共通
    public int HP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HP < 0)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "PlayerBullet")
        {
            HP -= 1;
        }
    }
}

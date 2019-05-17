using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAll : MonoBehaviour
{
    //エネミー共通
    [SerializeField]
    int HP;
    bool death;
    // Start is called before the first frame update
    void Start()
    {
        death = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            Destroy(gameObject);
            death = true;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            HP -= 1;
        }
    }
    public bool ReturnBool()
    {
        return death;
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDrop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
       other.gameObject.GetComponent<PlayerHp>().PlayerDamage(10f);
        Destroy(gameObject);
    }
}

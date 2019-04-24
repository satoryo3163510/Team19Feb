using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        //Playerと当たったら消す
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}

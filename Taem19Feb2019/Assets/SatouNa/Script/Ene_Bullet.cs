using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ene_Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log(other);
        }
        
    }

    void OnCollisonEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
            Destroy(gameObject);
        Debug.Log(other);
    }
}

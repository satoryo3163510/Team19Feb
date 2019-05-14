using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileShot : MonoBehaviour
{
    //ミサイル発射プログラム
    public GameObject missile;
    public Transform luncher;

    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject missiles = Instantiate(missile, 
                luncher.position, Quaternion.identity);
            Destroy(missiles, 5f);
        }
    }
}

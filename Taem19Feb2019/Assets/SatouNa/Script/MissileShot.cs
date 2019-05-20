using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileShot : MonoBehaviour
{
    //ミサイル発射プログラム
    public GameObject missile;
    public Transform luncher;
    private int nowCartrige;
    private int maxCartrige = 20;

    // Use this for initialization
    void Start()
    {
        nowCartrige = maxCartrige;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&nowCartrige!=0)
        {
            GameObject missiles = Instantiate(missile, 
                luncher.position, luncher.rotation);
            Destroy(missiles, 10);
            nowCartrige--;
        }
    }
}

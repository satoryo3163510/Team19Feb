using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_shield : MonoBehaviour
{
    public GameObject shield;
    EnemyAll all;
    // Start is called before the first frame update
    void Start()
    {
        all = new EnemyAll();
        GameObject kyoten = GameObject.Find("Kyoten");
        GameObject kyotenshield = Instantiate(shield,transform) as GameObject;
        kyotenshield.transform.position = kyoten.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

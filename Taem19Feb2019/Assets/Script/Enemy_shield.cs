using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_shield : MonoBehaviour
{
    public GameObject shield;
    // Start is called before the first frame update
    void Start()
    {
        GameObject kyoten = GameObject.Find("Kyoten");
        GameObject kyotenshield = Instantiate(shield,transform) as GameObject;
        kyotenshield.transform.position = kyoten.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

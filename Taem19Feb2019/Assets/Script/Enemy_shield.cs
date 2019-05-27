using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_shield : MonoBehaviour
{
    public GameObject shield;
    public Transform point;
    GameObject kyotenshield;
    // Start is called before the first frame update
    void Start()
    {
        kyotenshield = Instantiate(shield,transform) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        kyotenshield.transform.position = point.position;
    }
}

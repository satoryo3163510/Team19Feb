using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_shield : MonoBehaviour
{
    public GameObject shield;
    private int HP;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(shield,transform);
        HP = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

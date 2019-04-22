using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AirCraftCarrier : MonoBehaviour
{
    public GameObject enemyShip;
    private float timer;
    public float seisei = 5;
    private int HP;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        HP = 10;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > seisei)
        {
            GameObject ships = Instantiate(enemyShip) as GameObject;
            ships.transform.position = transform.position;
            timer = 0;
        }
    }
}
